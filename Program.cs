using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeily
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string[] codigos = { "OC-101", "OC-102", "OC-103", "OC-104", "OC-105", "OC-106" };
            string[] proveedores = { "TechCorp", "LogiExpress", "InsumosGlobal", "TechCorp", "AlfaSuministros", "ServiRedes" };
            double[,] datos = { { 150, 10 }, { 450, 2 }, { 80, 50 }, { 1200, 1 }, { 25, 100 }, { 600, 3 } };
            double[] montos = new double[6];
            double total = 0;
            int contador = 0;
            Console.WriteLine("************************************************");
            Console.WriteLine("    CONTROL DE ORDENES DE COMPRA");
            Console.WriteLine("************************************************");
            for (int i = 0; i < 6; i++)
                if (datos[i, 0] > 0 && datos[i, 1] > 0)
                {
                    montos[i] = datos[i, 0] * datos[i, 1];
                    total += montos[i];
                    if (montos[i] > 1000)
                        contador++;
                }
                else
                    Console.WriteLine("Datos incorrectos");
            for(int i = 0; i < 6; i++)
            {
              for(int j = 0; j < 5-i; j++)
              {
                  if(montos[j] < montos[j+1])
                  {
                     double tempMonto = montos[j];
                     montos[j] = montos[j + 1];
                     montos[j + 1] = tempMonto;
                     string tempCodigo = codigos[j];
                     codigos[j] = codigos[j + 1];
                     codigos[j + 1] = tempCodigo;
                     string tempProveedor = proveedores[j];
                     proveedores[j] = proveedores[j + 1];
                     proveedores[j + 1] = tempProveedor;
                  }
              }

            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("***************REPORTE ORDENADO*****************");
            Console.WriteLine("----------------------------------------------- ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine((i + 1) + ".codigo:" + codigos[i] + "prov:" +proveedores[i] + "Monto:$"
                    + montos[i].ToString("N2"));
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("*****************METRICAS***********************");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("total acumulado:$" + total.ToString("N2"));
            Console.WriteLine("Compras Criticas (>$1000):" + contador+"ordenador");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("************PRUEBA DE BUSQUEDA******************");
            Console.WriteLine("------------------------------------------------");
            string buscar = "OC-107";
            bool encontrado = false;
            for (int i = 0; i < 6; i++)
            {
                if (codigos[i] == buscar)
                {
                    Console.WriteLine("ENCONTRADO:" + proveedores[i]);
                    Console.WriteLine("Monto:$" + montos[i].ToString("N2"));
                    encontrado = true;
                }
                
            }
            if (encontrado == false)
            {
                Console.WriteLine("NO ENCONTRADO");
                Console.ReadKey();
            }
        }
    }
}





