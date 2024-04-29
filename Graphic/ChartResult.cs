using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Graphic
{
    public partial class ChartResult : Form
    {
        // Informações a serem exibidas no gráfico
        private Results.Info info;

        // Construtor que aceita uma instância de Info como argumento
        public ChartResult(Results.Info info)
        {
            InitializeComponent();
            this.info = info;
            CalculateAndShowPoints(); // Chama o método para exibir os pontos no gráfico
        }

        // Método para exibir os pontos no gráfico
        private void CalculateAndShowPoints()
        {
            // Limpa os pontos existentes no gráfico
            chartInfo.Series[0].Points.Clear();

            // Adiciona cada ponto ao gráfico com os valores X e Y da instância Info
            for (int i = 0; i < info.ValeurXList.Count; i++)
            {
                chartInfo.Series[0].Points.AddXY(info.ValeurXList[i], info.ValeurYList[i]);
            }
        }

        private void ChartResult_Load(object sender, EventArgs e)
        {

        }
    }
}
