using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainSecurity
{
    static class Program
    {
        public static User_Logger logger;
        public static SlideForm slideForm;

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            logger = new User_Logger();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //slideForm = new SlideForm();

            Application.Run(new StartForm());
            
        }
    }
}
