using System.Threading;
using System.Windows.Forms;

namespace Sync.Util
{
    public class LoadingCallPayGo
    {
        private LoadingScreen.LoadingPayGo LoadingScreen;
        private string _Texto;
        public LoadingCallPayGo(string Texto)
        {
            _Texto = Texto;
        }

        public void ShowLoading()
        {
            ShowLoadingWork();
        }

        private void ShowLoadingWork()
        {
            Thread LoadingThread = new Thread(() =>
            {
                LoadingScreen = new LoadingScreen.LoadingPayGo(_Texto);
                Application.Run(LoadingScreen);
            });
            LoadingThread.Start();
        }

        public void CloseLoading()
        {
            CloseLoadingWork();
        }

        private void CloseLoadingWork()
        {
            bool IsNull = true;
            while (IsNull)
            {
                if (LoadingScreen == null)
                    continue;

                if (LoadingScreen.IsHandleCreated == false)
                    continue;

                if (LoadingScreen.Visible == false)
                    continue;

                IsNull = false;
                LoadingScreen?.Invoke((MethodInvoker)(() => { LoadingScreen.Finish(); LoadingScreen.Close(); }));
            }
        }
    }
}
