using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using RPGCompanionApp.Model;

namespace RPGCompanionApp.DiceViewModel
{
    public partial class DiceViewModel : ObservableObject
    {
        [ObservableProperty]
        private int quantidadeDeDados;

        [ObservableProperty]
        private int quantidadeDeLados;

        [ObservableProperty]
        private int total;

        [ObservableProperty]
        private ObservableCollection <Dice> ListaDeDados;

        [ObservableProperty]
        private int numeroDeLados;

        public DiceViewModel()
        {
            RolarDadoCommand = new Command(RolarDados);
            ListaDeDados = new ObservableCollection <Dice>();
        }

        public ICommand RolarDadoCommand { get; }

        public void RolarDados()
        {   
            ListaDeDados.Clear();
            Total = 0;
            for (int i = 0; i < QuantidadeDeDados; i++) { }
                Dice dice = new Dice(QuantidadeDeLados);
                dice.RollDice();
                ListaDeDados.Add(dice);
                Total = Total + dice.NumeroSorteado;
        }
     }

}

