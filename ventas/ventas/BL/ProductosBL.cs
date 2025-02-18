﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.BL
{
    public class ProductosBL
    {
        public BindingList<Productos> ListadeProductos { get; set; }

        public ProductosBL()
        {
            ListadeProductos = new BindingList<Productos>();
            CrearDatosdePrueba();
        }
        public double ObtenerCosto(int id)
        {
            double costo = 0;

            foreach (var productos in ListadeProductos)
            {
                if (productos.Id == id)
                {
                    costo = productos.Costo;
                }
            }

            return costo;
        }

        public double ObtenerPrecio(int id)
        {
            double precio = 0;

            foreach (var productos in ListadeProductos)
            {
                if (productos.Id == id)
                {
                    precio = productos.Precio;
                }
            }

            return precio;
        }


        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            var producto1 = new Productos(1, "Laptop Dell", 15000, 12000, categoria1);

            var fileInfo = new FileInfo(@"C:\Users\Alba Gomez\Desktop\UNAH 2019\Lenguaje 2\Proyecto\Imagenes\dell.jpg");
            var fileStream = fileInfo.OpenRead();

            producto1.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var producto2 = new Productos(2, "Laptop Asus", 20000, 15000, categoria1);

            fileInfo = new FileInfo(@"C:\Users\Alba Gomez\Desktop\UNAH 2019\Lenguaje 2\Proyecto\Imagenes\asus.jpg");
            fileStream = fileInfo.OpenRead();

            producto2.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var producto3 = new Productos(3, "Mouse Logitech", 200, 100, categoria2);
            fileInfo = new FileInfo(@"C:\Users\Alba Gomez\Desktop\UNAH 2019\Lenguaje 2\Proyecto\Imagenes\descarga (4).jpg");
            fileStream = fileInfo.OpenRead();

            producto3.Foto = Program.imageToByteArray(Image.FromStream(fileStream));


            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);
        }
    }
}
