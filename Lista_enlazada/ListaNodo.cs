using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lista_enlazada
{
    internal class ListaNodo
    {
        private Nodo primero;
        private int size;
        public ListaNodo()
        {
            primero = null;
            size = 0;
        }
        public void addNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato);//add nodo
            Nodo valor1, valor2;
            if (primero == null)
            {
                primero = nuevo;
                //limpio y asignar al siguiente
                nuevo.siguiente = null;
            }
            else
            {
                valor1 = primero;
                while (valor1 != null)
                {
                    valor2 = valor1.siguiente;
                    //condicion que verifica si el numero debe de ir de pimero 
                    if (nuevo.dato <= valor1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else if (nuevo.dato > valor1.dato && valor2 == null)
                    //condicion donde que se ingresa debe ir al ultimo
                    {
                        valor1.siguiente = nuevo;
                        nuevo.siguiente = null;
                        break;
                    }
                    else if (valor1.dato < nuevo.dato && valor2.dato >= nuevo.dato)
                    {
                        valor1.siguiente = nuevo;
                        nuevo.siguiente = valor2;
                        break;
                    }
                    else
                    {
                        valor1 = valor1.siguiente;
                    }


                }
            }
        }
        public void ListaVacia()
        {
            if (primero == null)
            {
                Console.WriteLine("Esta lista esta vacia ingresa algun valor");
            }
            else
            {
                Console.WriteLine("La lista tiene datos");
            }
        }
        public void Listar()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.Write($"[{actual.dato}]->");
                actual = actual.siguiente;
            }
        }
        public void eliminar()
        {
            primero = primero.siguiente;
        }
        public void eliminarUltimo()
        {
            Nodo anteriro = primero;
            Nodo actual = primero;
            while (actual.siguiente != null)
            {
                anteriro = actual;
                actual = actual.siguiente;
            }
            anteriro.siguiente = null;
        }
        public void eliminarNodo(int p)
        {
            Nodo anteriro = primero;
            Nodo actual = primero;
            int dato = 0;
            if (p > 0)
            {
                while (dato != p && actual.siguiente != null)
                {
                    anteriro = actual;
                    actual = actual.siguiente;
                    dato++;

                }
                anteriro.siguiente = actual.siguiente;
            }
        }
        public Nodo Buscar(int n)
        {
            Nodo p = primero;
            if (p== null)
            {
                Console.WriteLine("La lista no tiene datos");
            }else
            {
                while (p.siguiente != null || p.siguiente== null)
                {
                    if (p.dato ==n)
                    {
                        return p;
                    }else if(p.siguiente== null)
                    {
                        return null;
                    }
                }
                p = p.siguiente;
            }
            return null;
        }
        public void sustituir(int origi,int nuevo)
        {
            Nodo pos = Buscar(origi);
            if (pos != null || pos == null)
            {
                pos.dato = nuevo;
            }
        }
        public int Size()
        {
            return size;
        }
    }
}
