using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flappy_Bird_windows_form
{
    public class Layer
    {

        private int width;
        private int start_speed;
        public int cut1_pos { get; set; }

        public int cut2_pos { get; set; }

        public int Speed { get; set; }

        public Layer(int cut1_pos, int width, int speed)
        {
            this.cut1_pos = cut1_pos;
            this.width = width;
            this.cut2_pos = width;
            Speed = speed;
            start_speed = speed;
        }
        public void layerReset()
        {
            cut1_pos = 0;
            cut2_pos = width;
            Speed = start_speed;
        }
        public void SetLayerPosition()
        {
            if (cut1_pos < -width)
            {
                cut1_pos = width - 10 * Speed;
            }
            cut1_pos -= Speed;
            cut2_pos -= Speed;
            if (cut2_pos < -width)
            {
                cut2_pos = width - 10 * Speed;
            }

        }
    }
}
