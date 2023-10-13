using System.Threading;
using System.Threading.Tasks;

namespace CarWaybills.Scripts.Services.Animations
{
    public class PageAnimation
    {
        public static async void DescOpacity(double FrameOpacity)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0.0; i -= 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);
                }
            });
        }

        public static async void IncOpacity(double FrameOpacity)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 0.0; i < 1.0; i += 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);
                }
            });
        }
    }
}
