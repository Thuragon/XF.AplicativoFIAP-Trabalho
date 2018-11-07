using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XF.AplicativoFIAP.Model;

namespace XF.AplicativoFIAP.ViewModel
{
    public class ProfessorViewModel : INotifyPropertyChanged
    {
        #region Propriedades
        public Professor ProfessorModel { get; set; }

        public ProfessorViewModel()
        {
            

        }


        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
