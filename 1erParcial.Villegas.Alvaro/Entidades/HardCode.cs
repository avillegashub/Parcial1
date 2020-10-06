using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HardCode
    {
        public static void HardCodeLogin()
        {
            Empleado e1 = new Admin("Apu", "Nahasapeemapetilon", 123, "asd");
            Empleado e2 = new Esclavo("Sanjay", "Nahasapeemapetilon", 98876433, "w0rkT!lldeath");
            Establecimiento.Clientes.Add(e1);
            Establecimiento.Empleados.Add(e1);
            Establecimiento.Clientes.Add(e2);
            Establecimiento.Empleados.Add(e2);
            Establecimiento.UserPassword.Add(e1.Dni.ToString(), e1.Password);
            Establecimiento.UserPassword.Add(e2.Dni.ToString(), e2.Password);

        }

        public static void HardCodeProductos()
        {
            Producto p1  = new Producto(10001, "Almohada",           3000,   11,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\almohada.png");
            Producto p2  = new Producto(10002, "Apache",             3200,   22,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\apache.png");
            Producto p3  = new Producto(10003, "Cama",               10450,  33,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\cama.png");
            Producto p4  = new Producto(10004, "Camisa IA",          11450,  44,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\camisaai.png");
            Producto p5  = new Producto(10005, "Camisa SexBob-Omb",  11460,  55,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\camisasbo.png");
            Producto p6  = new Producto(10006, "Carrito RC",         5460,   66,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\carrito.png");
            Producto p7  = new Producto(10007, "Cerealitas",         300,    77,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\cerealitas.png");
            Producto p8  = new Producto(10008, "Cobija",             5000,   88,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\cobija.png");
            Producto p9  = new Producto(10009, "DuffBeer",           100,    99,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\duffbeer.png");
            Producto p10 = new Producto(10010, "KramerArt",          500000, 1,   @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\kramer.png");
            Producto p11 = new Producto(10011, "MAGA Hat",           10,     100, @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\maga.png");
            Producto p12 = new Producto(10012, "Leche",              200,    101, @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\milk.png");
            Producto p13 = new Producto(10013, "Perro",              50000,  5,   @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\perrito.png");
            Producto p14 = new Producto(10014, "Pizza",              600,    123, @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\pizza.png");
            Producto p15 = new Producto(10015, "RTX2080",            60000,  5,   @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\rtx2080.png");
            Producto p16 = new Producto(10016, "Snickers",           200,    321, @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\snickers.png");
            Producto p17 = new Producto(10017, "TimeMachine",        1000,   1,   @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\timemachine.png");
            Producto p18 = new Producto(10018, "WindowsVista",       0,      999, @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\windowsvista.png");
            Producto p19 = new Producto(10019, "Zucaritas",          600,    99,  @"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\zucaritas.png");

            Establecimiento.AgregarProducto(p1);
            Establecimiento.AgregarProducto(p2);
            Establecimiento.AgregarProducto(p3);
            Establecimiento.AgregarProducto(p4);
            Establecimiento.AgregarProducto(p5);
            Establecimiento.AgregarProducto(p6);
            Establecimiento.AgregarProducto(p7);
            Establecimiento.AgregarProducto(p8);
            Establecimiento.AgregarProducto(p9);
            Establecimiento.AgregarProducto(p10);
            Establecimiento.AgregarProducto(p11);
            Establecimiento.AgregarProducto(p12);
            Establecimiento.AgregarProducto(p13);
            Establecimiento.AgregarProducto(p14);
            Establecimiento.AgregarProducto(p15);
            Establecimiento.AgregarProducto(p16);
            Establecimiento.AgregarProducto(p17);
            Establecimiento.AgregarProducto(p18);
            Establecimiento.AgregarProducto(p19);
            

            


        }

        public static void HardCodeCompras()
        {
            Compra c1 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 11111, 12, 11111, DateTime.Now.ToString(), 1231);
            Compra c2 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 22222, 12, 22222, DateTime.Now.ToString(), 1232);
            Compra c3 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 33333, 12, 33333, DateTime.Now.ToString(), 1233);
            Compra c4 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 44444, 12, 44444, DateTime.Now.ToString(), 1234);
            Compra c5 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 55555, 12, 55555, DateTime.Now.ToString(), 1235);
            Compra c6 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 66666, 12, 66666, DateTime.Now.ToString(), 1236);
            Compra c7 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 77777, 12, 77777, DateTime.Now.ToString(), 1237);
            Compra c8 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 88888, 12, 88888, DateTime.Now.ToString(), 1238);
            Compra c9 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 99999, 12, 99999, DateTime.Now.ToString(), 1239);
            Compra c10 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 121212, 12, 121212, DateTime.Now.ToString(), 1240);
            Compra c11 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 131313, 12, 131313, DateTime.Now.ToString(), 1241);
            Compra c12 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 141414, 12, 141414, DateTime.Now.ToString(), 1242);
            Compra c13 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 151515, 12, 151515, DateTime.Now.ToString(), 1243);
            Compra c14 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 161616, 12, 161616, DateTime.Now.ToString(), 1244);
            Compra c15 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 171717, 12, 171717, DateTime.Now.ToString(), 1245);
            Compra c16 = new Compra(Establecimiento.Empleados[0], Establecimiento.Clientes[0], Establecimiento.Productos, 181818, 12, 181818, DateTime.Now.ToString(), 1246);
            Compra c17 = new Compra(Establecimiento.Empleados[1], Establecimiento.Clientes[0], Establecimiento.Productos, 191919, 13, 191919, DateTime.Now.ToString(), 1247);
            Compra c18 = new Compra(Establecimiento.Empleados[1], Establecimiento.Clientes[0], Establecimiento.Productos, 202020, 13, 202020, DateTime.Now.ToString(), 1248);
            Compra c19 = new Compra(Establecimiento.Empleados[1], Establecimiento.Clientes[0], Establecimiento.Productos, 212121, 13, 212121, DateTime.Now.ToString(), 1249);
            Compra c20 = new Compra(Establecimiento.Empleados[1], Establecimiento.Clientes[0], Establecimiento.Productos, 222222, 13, 222222, DateTime.Now.ToString(), 1250);
            Establecimiento.AgregarCompra(c1);
            Establecimiento.AgregarCompra(c2);
            Establecimiento.AgregarCompra(c3);
            Establecimiento.AgregarCompra(c4);
            Establecimiento.AgregarCompra(c5);
            Establecimiento.AgregarCompra(c6);
            Establecimiento.AgregarCompra(c7);
            Establecimiento.AgregarCompra(c8);
            Establecimiento.AgregarCompra(c9);
            Establecimiento.AgregarCompra(c10);
            Establecimiento.AgregarCompra(c11);
            Establecimiento.AgregarCompra(c12);
            Establecimiento.AgregarCompra(c13);
            Establecimiento.AgregarCompra(c14);
            Establecimiento.AgregarCompra(c15);
            Establecimiento.AgregarCompra(c16);
            Establecimiento.AgregarCompra(c17);
            Establecimiento.AgregarCompra(c18);
            Establecimiento.AgregarCompra(c19);
            Establecimiento.AgregarCompra(c20);


        }

        public static void HardCodeClientes()
        {
            Cliente cc3 = new Cliente("Marge", "Simpson", 11111111);
            Cliente cc4 = new Cliente("Homer", "Simpson", 22222222);
            Cliente cc5 = new Cliente("Lisa", "Simpson", 33333333);
            Cliente cc6 = new Cliente("Bart", "Simpson", 44444444);
            Cliente cc7 = new Cliente("Ana", "Amari", 5555555);
            Cliente cc8 = new Cliente("Winston", " ", 6666666);
            Cliente cc9 = new Cliente("Aleksandra", "Zaryanova", 1);
            Cliente cc10 = new Cliente("Cloude", "Strife", 12);
            Cliente cc11 = new Cliente("Squall", "Leonhart", 1234);
            Cliente cc12 = new Cliente("Queen", "Peach", 1256);
            Cliente cc13 = new Cliente("Arthas", "Menethil", 1214);
            Cliente cc14 = new Cliente(" ", "SinNombre", 6451);
            Cliente cc15 = new Cliente("Ana", "Perez", 12414);
            Cliente cc16 = new Cliente("Pedro", "Perez", 4547);
            Cliente cc17 = new Cliente("Perez", "Simpson", 5474);

            Establecimiento.AgregarPersona(cc3);
            Establecimiento.AgregarPersona(cc4);
            Establecimiento.AgregarPersona(cc5);
            Establecimiento.AgregarPersona(cc6);
            Establecimiento.AgregarPersona(cc7);
            Establecimiento.AgregarPersona(cc8);
            Establecimiento.AgregarPersona(cc9);
            Establecimiento.AgregarPersona(cc10);
            Establecimiento.AgregarPersona(cc11);
            Establecimiento.AgregarPersona(cc12);
            Establecimiento.AgregarPersona(cc13);
            Establecimiento.AgregarPersona(cc14);
            Establecimiento.AgregarPersona(cc15);
            Establecimiento.AgregarPersona(cc16);
            Establecimiento.AgregarPersona(cc17);
        }


    }
}
