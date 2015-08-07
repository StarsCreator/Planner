using MetroFramework.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace Camozzi.GUI
{
    public class MoveMetroPanel: MetroPanel
    {
        //точка перемещения
        Point _downPoint;
        //нажата ли кнопка мыши
        bool _isDragMode;

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            _downPoint = mevent.Location;
            _isDragMode = true;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _isDragMode = false;
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            //если кнопка мыши нажата
            if (_isDragMode)
            {
                Point p = mevent.Location;
                //вычисляем разницу в координатах между положением курсора и "нулевой" точкой кнопки
                Point dp = new Point(p.X - _downPoint.X, p.Y - _downPoint.Y);
                Location = new Point(Location.X + dp.X, Location.Y + dp.Y);
            }
            base.OnMouseMove(mevent);
        }
    }
}
