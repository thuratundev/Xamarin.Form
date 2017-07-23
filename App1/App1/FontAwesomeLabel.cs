using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class FontAwesomeLabel : Label
    {
        public FontAwesomeLabel()
        {
            //   FontFamily = Device.OnPlatform(null, "FontAwesome", "/Assets/Fonts/fontawesome-webfont.ttf#FontAwesome");
            FontFamily = Device.OnPlatform(null, "FontAwesome", null);


        }
    }
}
