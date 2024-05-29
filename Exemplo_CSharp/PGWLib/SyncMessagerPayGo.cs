using PGWLib;
using System;
using System.Windows.Forms;

namespace Sync.Util
{
    public class SyncMessagerPayGo
    {
        static string Message = "";

        public static DialogResult CreateMessageIsUpdater(string NomeTela, string Descricao, string Color, bool ButtonCancelar, bool ForceDisableOthers, string CaminhoSolution)
        {
            return CreateMessageWorkIsUpdater(NomeTela, Descricao, Color, ButtonCancelar, ForceDisableOthers, CaminhoSolution);
        }

        public static DialogResult CreateMessage(int TipoTela, string NomeTela, string Descricao, string Color, bool ButtonCancelarNao, bool ForceDisableOthers, int DefaultButton = 0)
        {
            return CreateMessageWork(TipoTela, NomeTela, Descricao, Color, ButtonCancelarNao, ForceDisableOthers, false, false, DefaultButton);
        }

        public static void AddMessage(string Descricao)
        {
            Message += Descricao + "<br>";
        }

        public static DialogResult ShowMessages(int TipoTela, string NomeTela, string Color, bool ButtonCancelarNao, bool ForceDisableOthers, int DefaultButton = 0)
        {
            if (!string.IsNullOrWhiteSpace(Message)) 
            {
                DialogResult MessageShow = CreateMessageWork(TipoTela, NomeTela, Message, Color, ButtonCancelarNao, ForceDisableOthers, false, false, DefaultButton);

                Message = string.Empty;

                return MessageShow;
            }
            else
            {
                return DialogResult.Cancel;
            }
        }

        public static DialogResult CreateMessageAviso(string NomeTela, string Descricao, string Color, bool ButtonCancelar, bool ForceDisableOthers)
        {
            return CreateMessageWork(0, NomeTela, Descricao, Color, ButtonCancelar, ForceDisableOthers, false, true);
        }

        private static DialogResult CreateMessageWork(int TipoTela, string NomeTela, string Descricao, string Color, bool ButtonCancelar, bool ForceDisableOthers, bool IsUpdating, bool IsAviso, int DefaultButton = 0)
        {

            // Tipo Tela - 0 = Confirmar Cancelar, 1 = Sim e Não
            // Dafault Button - 0 = Cancelar, 1 = Confirmar

            MessageSyncPayGo Messager = new MessageSyncPayGo(TipoTela, NomeTela, Descricao, Color, ButtonCancelar, ForceDisableOthers, IsUpdating, IsAviso, DefaultButton);
            Messager.Shown += delegate (Object sender, EventArgs e)
            {
                // ((Form)sender).WindowState = FormWindowState.Normal;
                ((Form)sender).Activate();
            };
            //Messager.Activate();
            Messager.ShowDialog();
            return Messager.DialogResult;
        }

        private static DialogResult CreateMessageWorkIsUpdater(string NomeTela, string Descricao, string Color, bool ButtonCancelar, bool ForceDisableOthers, string CaminhoSolution)
        {

            MessageSyncPayGo Messager = new MessageSyncPayGo(NomeTela, Descricao, Color, ButtonCancelar, ForceDisableOthers, true, CaminhoSolution);
            Messager.Shown += delegate (Object sender, EventArgs e)
            {
                // ((Form)sender).WindowState = FormWindowState.Normal;
                ((Form)sender).Activate();
            };
            Messager.ShowDialog();
            return Messager.DialogResult;
        }

    }
}
