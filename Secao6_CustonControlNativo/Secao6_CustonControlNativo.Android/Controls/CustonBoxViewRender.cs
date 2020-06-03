using Android.Graphics;
using Xamarin.Forms.Platform.Android;
using Secao6_CustonControlNativo.Controls;
using System.Reflection;
using Xamarin.Forms;
using Secao6_CustonControlNativo.Droid.Controls;
using System.ComponentModel;
using Color = Android.Graphics.Color;

[assembly: ExportRenderer(typeof(CustomBoxView), typeof(CustonBoxViewRender))]
namespace Secao6_CustonControlNativo.Droid.Controls
{
    [System.Obsolete]
    public class CustonBoxViewRender : BoxRenderer
    {
        public CustonBoxViewRender()
        {
            SetWillNotDraw(false);
        }
        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);
            CustomBoxView control = (CustomBoxView)Element;
            Paint p = new Paint();
            p.StrokeWidth = (float)control.Espessura;
            p.Color = Color.White;
            
            //Retangulo
            Rect rect = new Rect(0, 0, 200, 200);
            canvas.DrawRect(rect, p);
            
            //Linhas
            canvas.DrawLine(100, 0, 100, 100, p);
            canvas.DrawLine(0, 100, 100, 100, p);
            
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}