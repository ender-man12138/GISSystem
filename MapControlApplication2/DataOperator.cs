using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Geometry;
using System.Data;
namespace MapControlApplication2
{
    class DataOperator
    {
        public static IFeatureClass OpenFeatureClass(string shpPath, string shpName)
        {
            //定义一个IWorkspaceFactory对象，用ShapefileWorkspaceFactoryClass构造函数初始化
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
            //调用IWorkspaceFactory的OpenFromFile方法，并赋值给一个IWorkspace的对象
            IWorkspace workspace = workspaceFactory.OpenFromFile(shpPath, 0);
            //将IWorkspace对象接口转换为IFeatureWorkspace对象
            IFeatureWorkspace featureWorkSpace = workspace as IFeatureWorkspace;
            //调用IFeatureWorkspace的OpenFeatureClass方法，并赋值给一个IFeatureClass的对象
            IFeatureClass featureClass = featureWorkSpace.OpenFeatureClass(shpName);
            //返回该IFeatureClass对象
            return featureClass;
        }
        public static IFeatureClass OpenGDBFeatureClass(string DBPath, string clsName)
        {
            // 定义一个IWorkspaceFactory对象，用FileGDBWorkspaceFactoryClass构造函数初始化
            IWorkspaceFactory workspaceFactory = new FileGDBWorkspaceFactoryClass();
            //调用IWorkspaceFactory的OpenFromFile方法，并赋值给一个IWorkspace的对象
            IWorkspace workspace = workspaceFactory.OpenFromFile(DBPath, 0);
            //将IWorkspace对象接口转换为IFeatureWorkspace对象
            IFeatureWorkspace gdbWorkSpace = workspace as IFeatureWorkspace;
            //调用IFeatureWorkspace的OpenFeatureClass方法，并赋值给一个IFeatureClass的对象
            IFeatureClass tfeatureClass = gdbWorkSpace.OpenFeatureClass(clsName);
            //返回该IFeatureClass对象
            return tfeatureClass;
        }
        public static IFeatureClass CreateShapefile(string shpPath, string shpName, ISpatialReference spatialRef)
        {
            IFeatureClass featCls = null;
            //定义一个IWorkspaceFactory对象，用ShapefileWorkspaceFactoryClass构造函数初始化
            IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
            //调用IWorkspaceFactory的OpenFromFile方法，并赋值给一个IWorkspace的对象
            IWorkspace workspace = workspaceFactory.OpenFromFile(shpPath, 0);
            //将IWorkspace对象接口转换为IFeatureWorkspace对象 
            IFeatureWorkspace featureWS = workspace as IFeatureWorkspace;
            //创建并编辑要素类所需的字段集
            IFields fields = new FieldsClass();
            IFieldsEdit fieldsEdit = fields as IFieldsEdit;
            //创建并编辑序号字段，此字段为要素类必需字段
            IFieldEdit fieldEdit = new FieldClass();
            fieldEdit.Name_2 = "OID";
            fieldEdit.AliasName_2 = "序号";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeOID;
            fieldsEdit.AddField(fieldEdit as IField);
            //创建并编辑"名称"字段，字段类型为文本型，该部分代码大家仿照写出
            fieldEdit = new FieldClass();
            fieldEdit.Name_2 = "Name";
            fieldEdit.AliasName_2 = "名称";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeString;
            fieldsEdit.AddField(fieldEdit as IField);
            //创建几何图形定义，设置空间参考和几何类型，为添加图形字段作准备 
            IGeometryDefEdit geoDefEdit = new GeometryDefClass();
            geoDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;
            geoDefEdit.SpatialReference_2 = spatialRef;
            //创建并编辑"形状"字段
            fieldEdit = new FieldClass();
            fieldEdit.Name_2 = "Shape";
            fieldEdit.AliasName_2 = "形状";
            fieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
            fieldEdit.GeometryDef_2 = geoDefEdit as IGeometryDef;
            fieldsEdit.AddField(fieldEdit as IField);
            //创建要素类
            featCls = featureWS.CreateFeatureClass(shpName, fields, null, null, esriFeatureType.esriFTSimple, "Shape", "");
            return featCls;
        }
        public static bool AddFeatureLayer(IMap map, IFeatureClass featureClass)
        {
            //设置IFeatureLayer的FeatureClass属性为参数featureClass的值
            IFeatureLayer featureLayer = new FeatureLayerClass();
            featureLayer.FeatureClass = featureClass;
            //设置IFeatureLayer的Name属性为参数featureClass的AliasName属性
            featureLayer.Name = featureLayer.FeatureClass.AliasName;
            //将IFeatureLayer对象接口转换为ILayer对象
            ILayer layer = featureLayer as ILayer;
            //调用IMap的AddLayer方法，将上一步得到的ILayer对象作为参数传入
            map.AddLayer(layer);
            //返回true；
            return true;
        }

        public static int SUMschool(IFeatureLayer feaLyr)
        {
            int sum = 0;
            IFeatureClass featCls = feaLyr.FeatureClass;
            if (featCls != null)
            {
                IFeatureSelection featureSelection = feaLyr as IFeatureSelection;
                ISelectionSet selectionSet = featureSelection.SelectionSet;
                ICursor cursor;
                selectionSet.Search(null, false, out cursor);
                IFeatureCursor featCursor = cursor as IFeatureCursor;

                IFeature feat = featCursor.NextFeature();
                while (feat != null)
                {
                    // 获取FID字段值并转换为整数
                    string fidStr = feat.get_Value(0).ToString(); // FID在第一列
                    int fidValue;
                    if(int.TryParse(fidStr, out fidValue))
                    {
                        sum += fidValue;
                    }
                    feat = featCursor.NextFeature();
                }
            }
           
            return sum;
        }

        public static DataTable GetAttributeTable(IFeatureLayer feaLyr, bool bool1)
        {
            //创建一个新的数据表对象
            DataTable dt = new DataTable();
            //获取要素图层的要素类
            IFeatureClass featCls = feaLyr.FeatureClass;
            if (featCls != null)
            {   //循环1，得到表结构
                for (int i = 0; i < featCls.Fields.FieldCount; i++)
                {
                    //创建数据列并添加到数据表中
                    DataColumn dc = new DataColumn(featCls.Fields.get_Field(i).Name);
                    dt.Columns.Add(dc);
                }
                //实验三得到所有要素（没有任何查询条件）的游标Cursor，实验八要得到选中要素的游标

                //声明要素游标对象
                IFeatureCursor featCursor;
                //如果是全部要素
                if (bool1)
                {//使用IFeatureClass的Search方法得到IFeatureCursor【原来的方式】
                    featCursor = featCls.Search(null, false);
                }
                else
                {
                    //先先得到IFeatureSelection，把IFeatureLayer对象转换过来
                    IFeatureSelection featureSelection = feaLyr as IFeatureSelection;
                    //先得到ISelectionSet，获取IFeatureSelection的SelectionSet属性得到
                    ISelectionSet selectionSet = featureSelection.SelectionSet;
                    //使用ISelectionSet的Search方法得到ICursor
                    ICursor cursor;
                    selectionSet.Search(null, false, out cursor);
                    //把ICursor转换为IFeatureCursor
                    featCursor = cursor as IFeatureCursor;
                }
                //获取第一个要素
                IFeature feat = featCursor.NextFeature();
                //循环遍历所有的Feature
                while (feat != null)
                {
                    //创建新的数据行
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < feat.Fields.FieldCount; j++)
                    {
                        //读取Feature的字段值
                        dr[j] = feat.get_Value(j).ToString();
                        //如果是几何字段，则根据几何类型显示对应的中文描述
                        if (feat.Fields.Field[j].Type == esriFieldType.esriFieldTypeGeometry)
                        {
                            if (featCls.ShapeType == esriGeometryType.esriGeometryPoint)
                            {
                                dr[j] = "点";
                            }
                            else if (featCls.ShapeType == esriGeometryType.esriGeometryPolyline)
                            {
                                dr[j] = "线";
                            }
                            else if (featCls.ShapeType == esriGeometryType.esriGeometryPolygon)
                            {
                                dr[j] = "面";
                            }

                        }
                    }
                    //将数据行添加到数据表中
                    dt.Rows.Add(dr);
                    //获取下一个要素
                    feat = featCursor.NextFeature();
                }
            }
            //返回填充好的数据表
            return dt;
        }
        public static ILayer GetLayerByName(IMap map,string lyrName)
        {
            if(map==null||lyrName=="")
            {
                return null;
            }
            for(int i=0;i<map.LayerCount;i++)
            {
                if(map.Layer[i].Name==lyrName)
                {
                    return map.Layer[i];
                }
            }
            return null;
        }
        public static IPolyline GetPolylineGeometry()
        {
            IPolyline polyline = null;
            IPointCollection pointColl = new PolylineClass();
            //计算2001个点组成抛物线
            //y = -0.005x^2       
            for (int i = -1000; i < 1000; i++)
            {
                IPoint frompoint = new PointClass();
                frompoint.PutCoords(i, -0.005 * i * i);
                pointColl.AddPoint(frompoint);
            }
            polyline = pointColl as IPolyline;
            return polyline;
        }
        public static IPolygon GetPolygonGeometry()
        {
            IPolygon polygon = null;
            IPointCollection pointColl = new PolygonClass();
            //计算2001个点组成抛物线y = -0.005x^2围成的面       
            for (int i = -1000; i < 1000; i++)
            {
                IPoint frompoint1 = new PointClass();
                frompoint1.PutCoords(i, -0.005 * i * i);
                pointColl.AddPoint(frompoint1);
            }
            //添加第一个点;;
            IPoint frompoint = new PointClass();
            frompoint.PutCoords(-1000, -0.005 * (-1000) * (-1000));
            pointColl.AddPoint(frompoint);
            polygon = pointColl as IPolygon;
            return polygon;

        }
        public static void AddFeature(IFeatureLayer featLyr, IGeometry geometry)
        {
            //1.得到工作空间（根据已有的图层找到数据对应的工作空间），并开始编辑

            //2.得到一个插入游标

            //3.得到一个空的要素

            //4.设置该要素的图形和属性

            //5.利用插入游标将该要素保存到文件中
            //featureCursor.InsertFeature(featureBuffer);
            //featureCursor.Flush();
            //workspaceEdit.StopEditOperation();
            //workspaceEdit.StopEditing(true);


            IFeatureClass featureClass = featLyr.FeatureClass;
            //判断传进来的layer和geometry类型是否一致
            if (featureClass.ShapeType != geometry.GeometryType)
            {
                return;
            }

            IDataset dataset = featureClass as IDataset;
            IWorkspace workspace = dataset.Workspace;
            //开始空间编辑
            IWorkspaceEdit workspaceEdit = workspace as IWorkspaceEdit;
            workspaceEdit.StartEditing(true);
            workspaceEdit.StartEditOperation();

            //创建一个要素缓存，与插入游标cursor一起用来插入要素
            IFeatureBuffer featureBuffer = featureClass.CreateFeatureBuffer();
            featureBuffer.Shape = geometry;

            ////以下代码为测试设置其他字段值
            //int index = featureBuffer.Fields.FindField("Name");
            //featureBuffer.set_Value(index, "测试点");

            //得到一个游标cursor，用来后续插入新的实体对象
            IFeatureCursor featureCursor = featureClass.Insert(true);
            //插入要素
            featureCursor.InsertFeature(featureBuffer);
            int i = featureBuffer.Fields.FindField("Name");
            if(i!=-1)
            {
                featureBuffer.Value[i] = "测试";
            }
            //写入FeatureClass对应的文件
            featureCursor.Flush();
            //结束空间编辑
            workspaceEdit.StopEditOperation();
            workspaceEdit.StopEditing(true);

        }
      

    }
}
