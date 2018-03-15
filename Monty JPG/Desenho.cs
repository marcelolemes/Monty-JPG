using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_JPG
{
    class Desenho
    {
        //Graphics g;

        public static void desenhar(String caminho) {

            //Parte copiada inicia aqui

            Point[] destinationPoints = {
                new Point(200, 20),   // destination for upper-left point of 
                                                                                  // original
                new Point(110, 100),  // destination for upper-right point of 
                                                                            // original
                new Point(250, 30)};  // destination for lower-left point of 
                                                                          // original

            //Parte copiada termina aqui

            Bitmap fotoTemp, fotoTemp2;  // Variaveis que abrigarão as fotos em processo de manipulação
            fotoTemp = new Bitmap(caminho);

            using (Graphics g = Graphics.FromImage(fotoTemp)) {

                g.DrawImage(fotoTemp, destinationPoints);
                //            g.Save("N://Teste Compilado.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

               
            }

            fotoTemp.Save("N://Teste Compilado.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }
    }
}
