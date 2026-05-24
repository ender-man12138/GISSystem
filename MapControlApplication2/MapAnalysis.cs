using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapControlApplication2
{
    class MapAnalysis
    {
      

        public static void QueryByAttr(IFeatureLayer featureLayer,string strWhere)
        {
            //调用IFeatureSelection的SelectFeatures方法
            //Q:怎么得到IFeatureSelection的对象?
            //A：通过接口转换把IFeatureLayer类型的对象转换为IFeatureSelection类型的对象
            IFeatureSelection featureSelection = featureLayer as IFeatureSelection;
            //传什么类型的参数进来（IQueryFilter类型）
            //Q:怎么得到IQueryFilter类型的对象
            //A:直接使用QueryFilterClass的构造函数初始化得到
            IQueryFilter queryFilter = new QueryFilterClass();
            //Q:怎么把查询条件txtWhere传递给上面的IQueryFilter对象
            //A:直接把查询条件赋值给IQueryFilter对象的WhereClause属性
            queryFilter.WhereClause = strWhere;
            featureSelection.SelectFeatures(queryFilter, esriSelectionResultEnum.esriSelectionResultNew,false);
        }
        public static  void QueryByGeometry(IFeatureLayer featureLayer,IGeometry geometry)
        {
            if (featureLayer == null || geometry == null)
            {
                return;
            }
            IFeatureSelection featureSelection = featureLayer as IFeatureSelection;
            ISpatialFilter spatialFilter = new SpatialFilterClass();
            spatialFilter.Geometry = geometry;
            if(featureLayer.FeatureClass.ShapeType==esriGeometryType.esriGeometryPoint)
            {
                spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelContains;
            }
            else if(featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPolyline)
            {
                spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIndexIntersects;
            }
            else if(featureLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPolygon)
            {
                spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIndexIntersects;
            }
            featureSelection.SelectFeatures(spatialFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
        }
        public static bool BufferAnalysis(IFeatureLayer featureLayer,string outpath,double radius,string strUnit,out string strMsg)
        {
            ESRI.ArcGIS.Geoprocessor.Geoprocessor gp = new ESRI.ArcGIS.Geoprocessor.Geoprocessor();
            gp.OverwriteOutput = true;

            ESRI.ArcGIS.AnalysisTools.Buffer buffer = new ESRI.ArcGIS.AnalysisTools.Buffer(featureLayer, outpath, radius + " " + strUnit);

            buffer.dissolve_option = "ALL";
            buffer.line_side = "FULL";
            buffer.line_end_type = "ROUND";


            IGeoProcessorResult results = null;
            try
            {
                results = (IGeoProcessorResult)gp.Execute(buffer, null);
                strMsg = results.GetMessages(0);
                return true;
            }
            catch (Exception ex)
            {
                strMsg = results.GetMessages(0);
                return false;
            }

        }
        public static bool BufferAnalysis(object shapepath, string outpath, double radius, string strUnit, out string strMsg)
        {
            Geoprocessor gp = new Geoprocessor();
            gp.OverwriteOutput = true;
            //create a new instance of a buffer tool
            ESRI.ArcGIS.AnalysisTools.Buffer buffer = new ESRI.ArcGIS.AnalysisTools.Buffer(shapepath, outpath, radius + " " + strUnit);
            //ESRI.ArcGIS.AnalysisTools.Buffer buffer = new ESRI.ArcGIS.AnalysisTools.Buffer (layer, this.OutputPath, "100"+" "+"Meters" );
            buffer.dissolve_option = "ALL";//这个要设成ALL,否则相交部分不会融合
            buffer.line_side = "FULL";//默认是"FULL",最好不要改否则出错
            buffer.line_end_type = "ROUND";//默认是"ROUND",最好不要改否则出错
                                           //execute the buffer tool (very easy :-))
            IGeoProcessorResult results = null;
            try
            {
                results = (IGeoProcessorResult)gp.Execute(buffer, null);
                results = gp.Execute(buffer, null) as IGeoProcessorResult;
                strMsg = results.GetMessages(0);
                return true;
                //.Show("缓冲区建立成功！");
            }
            catch (Exception ex)
            {
                strMsg = ex.Message;
                return false;
                //MessageBox.Show("缓冲区建立失败！");
                // txtMessages.Text += "Failed to buffer layer: " + layer.Name + "\r\n";
            }

        }
    }
}
