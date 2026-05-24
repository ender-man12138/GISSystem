using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using stdole;
using System.Drawing;
using ESRI.ArcGIS.ADF.COMSupport;

namespace MapControlApplication2
{
    class MapComposer
    {
        //定义静态方法PointRenderSimply，无返回值，6个参数分别为以下类型：
        public static void PointRenderSimply(IFeatureLayer featureLayer, IColor color, double size,
            bool outline, IColor outlineColor, double outlineSize)
        {

            IFeatureClass featureClass = featureLayer.FeatureClass;
            esriGeometryType geoType = featureClass.ShapeType;
            if (geoType == esriGeometryType.esriGeometryPoint)
            {
                //定义一个点符号
                ISimpleMarkerSymbol markerSymbol = new SimpleMarkerSymbolClass();
                markerSymbol.Color = color;
                markerSymbol.Outline = outline;
                markerSymbol.OutlineColor = outlineColor;
                markerSymbol.OutlineSize = outlineSize;
                markerSymbol.Size = size;
                //定义一个渲染器
                ISimpleRenderer sRenderer = new SimpleRendererClass();
                sRenderer.Symbol = markerSymbol as ISymbol;
                //设置矢量图层的渲染器
                IGeoFeatureLayer geoFeatureLayer = featureLayer as IGeoFeatureLayer;
                geoFeatureLayer.Renderer = sRenderer as IFeatureRenderer;
            }

        }
        //定义静态方法PolylineRenderSimply，无返回值，3个参数？
        public static void PolylineRenderSimply(IFeatureLayer featureLayer, IColor color, double size)
        {

            IFeatureClass featureClass = featureLayer.FeatureClass;
            if (featureClass != null && featureClass.ShapeType == esriGeometryType.esriGeometryPolyline)
            {
                ISimpleLineSymbol lineSymbol = new SimpleLineSymbolClass();
                lineSymbol.Width = size;//double
                lineSymbol.Color = color;//IColor

                //定义渲染器
                ISimpleRenderer sRenderer = new SimpleRendererClass();
                sRenderer.Symbol = lineSymbol as ISymbol;

                //设置矢量图层的渲染器
                IGeoFeatureLayer geoFeatureLayer = featureLayer as IGeoFeatureLayer;
                geoFeatureLayer.Renderer = sRenderer as IFeatureRenderer;
            }

        }
        //定义静态方法PolylineRenderSimply，无返回值，3个

        //定义静态方法PolygonRenderSimply，无返回值，6个参数 or 5个参数？
        public static void PolygonRenderSimply(IFeatureLayer featureLayer, IColor panelColor, IColor panelOutlineColor, double OutlineSize)
        {
            IFeatureClass featureClass = featureLayer.FeatureClass;
            if (featureClass != null && featureClass.ShapeType == esriGeometryType.esriGeometryPolygon)
            {
                ISimpleLineSymbol lineSymbol = new SimpleLineSymbolClass();
                lineSymbol.Width = OutlineSize;//double
                lineSymbol.Color = panelOutlineColor;//IColor

                ISimpleFillSymbol polygonSymbol = new SimpleFillSymbolClass();
                polygonSymbol.Color = panelColor;
                polygonSymbol.Outline = lineSymbol;

                //定义渲染器
                ISimpleRenderer sRenderer = new SimpleRendererClass();
                sRenderer.Symbol = polygonSymbol as ISymbol;

                //设置矢量图层的渲染器
                IGeoFeatureLayer geoFeatureLayer = featureLayer as IGeoFeatureLayer;
                geoFeatureLayer.Renderer = sRenderer as IFeatureRenderer;
            }
        }


        public static void CopyMap(IMap fromMap, IMap toMap)
        {
            IObjectCopy objectCopy = new ObjectCopyClass();
            object copyFromMap = fromMap;
            //调用IObjectCopy的Copy方法，先把源地图的内容复制上
            object copyMap = objectCopy.Copy(copyFromMap);
            object copyToMap = toMap;
            //调用IObjectCopy的Overwrite方法，把先前复制的地图内容粘贴到目标地图上
            objectCopy.Overwrite(copyMap, ref copyToMap);
        }
        public static void AddNorthArrow(IPageLayout pageLayout, IMap map)
        {
            if (pageLayout == null || map == null)
            {
                return;
            }

            //设置大小
            ESRI.ArcGIS.Geometry.IEnvelope envelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            envelope.PutCoords(100, 200, 18, 25);
            //设置标志
            ESRI.ArcGIS.esriSystem.IUID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = "esriCarto.MarkerNorthArrow";

            //1、得到整饬要素的存放容器GraphicsContainer
            IGraphicsContainer graphicsContainer = pageLayout as IGraphicsContainer;
            //2、在容器GraphicsContainer中找到地图框架MapFrame
            IFrameElement frameElement = graphicsContainer.FindFrame(map);
            IMapFrame mapFrame = frameElement as IMapFrame;
            //3、调用IMapFrame接口的CreateSurroundFrame方法得到整饬要素框架MapSurroundFrame
            IMapSurroundFrame mapSurroundFrame = mapFrame.CreateSurroundFrame(uid as UID, null);
            //4、设置MapSurroundFrame（也是元素Element）的大小
            IElement element = mapSurroundFrame as IElement;
            //5、准备绘制该元素
            IActiveView activeView = pageLayout as IActiveView;
            element.Geometry = envelope;
            element.Activate(activeView.ScreenDisplay);
            graphicsContainer.AddElement(element, 0);
            IMapSurround mapSurround = mapSurroundFrame.MapSurround;
            //6.刷新
            activeView.Refresh();
        }
        public static void AddScaleBar(IPageLayout pageLayout, IMap map)
        {

            if (pageLayout == null || map == null)
            {
                return;
            }

            //设置大小
            ESRI.ArcGIS.Geometry.IEnvelope envelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            envelope.PutCoords(2, 4, 20, 3);
            //设置标志
            ESRI.ArcGIS.esriSystem.IUID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = "esriCarto.AlternatingScaleBar";

            //1、得到整饬要素的存放容器GraphicsContainer
            IGraphicsContainer graphicsContainer = pageLayout as IGraphicsContainer;
            //2、在容器GraphicsContainer中找到地图框架MapFrame
            IFrameElement frameElement = graphicsContainer.FindFrame(map);
            IMapFrame mapFrame = frameElement as IMapFrame;
            //3、调用IMapFrame接口的CreateSurroundFrame方法得到整饬要素框架MapSurroundFrame
            IMapSurroundFrame mapSurroundFrame = mapFrame.CreateSurroundFrame(uid as UID, null);
            //4、设置MapSurroundFrame（也是元素Element）的大小
            IElement element = mapSurroundFrame as IElement;
            //5、准备绘制该元素
            IActiveView activeView = pageLayout as IActiveView;
            element.Geometry = envelope;
            element.Activate(activeView.ScreenDisplay);
            graphicsContainer.AddElement(element, 0);
            IMapSurround mapSurround = mapSurroundFrame.MapSurround;
            //6.刷新
            activeView.Refresh();
        }
        public static void AddLegend(IPageLayout pageLayout, IMap map)
        {

            if (pageLayout == null || map == null)
            {
                return;
            }

            //设置大小与位置
            ESRI.ArcGIS.Geometry.IEnvelope envelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            envelope.PutCoords(100, 200, 17,5);
            //设置标志
            ESRI.ArcGIS.esriSystem.IUID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = "esriCarto.Legend";

            //1、得到整饬要素的存放容器GraphicsContainer
            IGraphicsContainer graphicsContainer = pageLayout as IGraphicsContainer;
            //2、在容器GraphicsContainer中找到地图框架MapFrame
            IFrameElement frameElement = graphicsContainer.FindFrame(map);
            IMapFrame mapFrame = frameElement as IMapFrame;
            //3、调用IMapFrame接口的CreateSurroundFrame方法得到整饬要素框架MapSurroundFrame
            IMapSurroundFrame mapSurroundFrame = mapFrame.CreateSurroundFrame(uid as UID, null);
            //4、设置MapSurroundFrame（也是元素Element）的大小
            IElement element = mapSurroundFrame as IElement;
            //5、准备绘制该元素
            IActiveView activeView = pageLayout as IActiveView;
            element.Geometry = envelope;
            element.Activate(activeView.ScreenDisplay);
            graphicsContainer.AddElement(element, 0);
            IMapSurround mapSurround = mapSurroundFrame.MapSurround;
            //6.刷新
            activeView.Refresh();
        }
        public static void AddMapTitle(IPageLayout pageLayout, IMap map)
        {
            if (pageLayout == null || map == null)
            {
                return;
            }

            InsertTitle frmtitle = new InsertTitle();
            if (frmtitle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                IGraphicsContainer pGraphicsContainer = pageLayout as IGraphicsContainer;
                //设置文本格式
                ITextSymbol pTextSymbol = new TextSymbolClass();
                pTextSymbol.Font = OLE.GetIFontDispFromFont(frmtitle.font) as IFontDisp;
                //颜色修改为黑色
                IRgbColor rgbColor = new RgbColor();
                rgbColor.Red = frmtitle.titleColor.R;
                rgbColor.Green = frmtitle.titleColor.G;
                rgbColor.Blue = frmtitle.titleColor.B;
                pTextSymbol.Color = rgbColor;
                pTextSymbol.Angle = 0;
                pTextSymbol.RightToLeft = false;//文本由左向右排列
                pTextSymbol.VerticalAlignment = esriTextVerticalAlignment.esriTVACenter;//垂直方向基线对齐
                pTextSymbol.HorizontalAlignment = esriTextHorizontalAlignment.esriTHALeft;//文本两端对齐
                pTextSymbol.Text = frmtitle.title;//myTitle为string类型的变量，里面存放地图标题

                ITextElement pTextElement = new TextElementClass();
                pTextElement.Symbol = pTextSymbol;
                pTextElement.Text = pTextSymbol.Text;

                IElement pElement = (IElement)pTextElement;
                //位置
                ESRI.ArcGIS.Geometry.IEnvelope envelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
                envelope.PutCoords(5, 5, 7, 7);
                pElement.Geometry = envelope;

                pGraphicsContainer.AddElement(pElement, 0);

                //6.刷新
                IActiveView activeView = pageLayout as IActiveView;
                activeView.Refresh();
            }
            else return;
        }
        public static void AddDateTimeStamp(IPageLayout pageLayout)
        {
            if (pageLayout == null)
            {
                return;
            }

            // 创建一个点对象以确定文本的位置
            IPoint point = new PointClass();
            point.PutCoords(18, 25); // 设置文本位置坐标，根据需要调整

            // 创建一个文本元素并设置其文本内容为当前的时间戳
            ITextElement textElement = new TextElementClass();
            IElement element = (IElement)textElement;

            // 设置文本内容
            textElement.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 创建并设置文本符号（包括字体、颜色等）
            ITextSymbol textSymbol = new TextSymbolClass();
            textSymbol.Size = 12; // 字体大小
            textSymbol.Color = new RgbColorClass { Red = 0, Green = 0, Blue = 0 }; // 黑色

            // 使用StdFont创建字体对象，并设置给文本符号
            StdFont stdFont = new StdFont();
            stdFont.Name = "Arial"; // 字体名称
            stdFont.Size = 12; // 字体大小
            textSymbol.Font = (IFontDisp)stdFont;

            textElement.Symbol = textSymbol;

            // 设置文本元素的几何位置
            element.Geometry = point;

            // 将文本元素添加到图形容器
            IGraphicsContainer graphicsContainer = (IGraphicsContainer)pageLayout;
            graphicsContainer.AddElement(element, 0);

            // 刷新页面布局以显示新的元素
            IActiveView activeView = (IActiveView)pageLayout;
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }

    }
}
