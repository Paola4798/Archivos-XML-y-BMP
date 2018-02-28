using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace bmp_y_xml
{
    public partial class Form1 : Form
    {
        char primerbit, segundobit;
        int alto, ancho, bytes, bytesxp;
        public Form1()
        {
            InitializeComponent();
        }

        private bool esArchivoBMP(FileStream archivo)
        {
            BinaryReader br = new BinaryReader(archivo);

            br.BaseStream.Seek(0, SeekOrigin.Begin);
            //Se necesita para base de referenicia: orgin //Empezar 
            primerbit = Convert.ToChar(br.ReadByte());
            br.BaseStream.Seek(1, SeekOrigin.Begin);
            segundobit = Convert.ToChar(br.ReadByte());
            if (primerbit == 'B' && segundobit == 'M')
            {
                //Console.WriteLine("Marca del fichero: {0}{1}", primerbit, segundobit);
                //txtBmp.Text += "es bmp";
                return true;
            }
            else
            {
                br.Close();
                archivo.Close();
                //Console.WriteLine("no es bmp");
                txtBmp.Text += "no es bmp";
                return false;
            }
        }
        private int tamaño(FileStream archivo)
        {

            BinaryReader br = new BinaryReader(archivo);

            br.BaseStream.Seek(2, SeekOrigin.Begin);
            //2da posición en un archivo bmp para el tamaño de bytes
            bytes = br.ReadInt32();
            //Console.WriteLine("Tamaño real en bytes: " + bytes);
            txtBmp.Text += "Tamaño real en bytes: " + bytes;
            return bytes;
        }


        private int Ancho_y_Altura_Imagen(FileStream archivo)
        {
            BinaryReader br = new BinaryReader(archivo);

            br.BaseStream.Seek(18, SeekOrigin.Begin);
            //18 posición en un archivo bmp para el ancho de una imagen
            ancho = br.ReadInt32();
            //Console.WriteLine("Ancho:{0} ", ancho);
            txtBmp.Text += Environment.NewLine + "Ancho de la imagen: " + ancho;
            alto = br.ReadInt32();
            //Console.WriteLine("Alto:{0} ", alto);
            txtBmp.Text += Environment.NewLine + "Alto de la imagen: " + alto;
            return ancho + alto;

        }
        private int bits_por_Pixel(FileStream archivo)
        {
            BinaryReader br = new BinaryReader(archivo);

            br.BaseStream.Seek(28, SeekOrigin.Begin);
            //28 posición en un archivo bmp para el bits por pixel
            bytesxp = br.ReadInt16();
            //Console.WriteLine("Bits por pixel:{0} ", bytesxp);
            txtBmp.Text += Environment.NewLine + "Bits por pixel: " + bytesxp;
            return bytesxp;
        }



        private void btnOpenBmp_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            FileStream archivo = new FileStream(ofd.FileName, FileMode.Open);


            if (esArchivoBMP(archivo) == true)
            {
                tamaño(archivo);
                Ancho_y_Altura_Imagen(archivo);
                bits_por_Pixel(archivo);
            }
            archivo.Close();
        }

        public void CrearXml(XmlDocument doc, string nombre, string Edad, string Telefono, string Domicilio, string Lugar_de_nacimieto)
        {
            XmlDeclaration documento = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            XmlElement element = doc.DocumentElement;
            doc.InsertBefore(documento, element);
            

            XmlNode node = doc.CreateElement("Agenda");
            doc.AppendChild(node);
            XmlNode usNode = doc.CreateElement("Registros");
            XmlAttribute name = doc.CreateAttribute("Nombre");
            name.Value = nombre; 
            usNode.Attributes.Append(name);
            XmlAttribute age = doc.CreateAttribute("Edad");
            age.Value = Edad;
            usNode.Attributes.Append(age);
            XmlAttribute telefono = doc.CreateAttribute("Telefono");
            telefono.Value = Telefono;
            usNode.Attributes.Append(telefono);
            XmlAttribute domicilio = doc.CreateAttribute("Domicilio");
            domicilio.Value = Domicilio;
            usNode.Attributes.Append(domicilio);
            XmlAttribute Lugar = doc.CreateAttribute("Lugar de nacimiento");
            Lugar.Value = Lugar_de_nacimieto;
            usNode.Attributes.Append(Lugar);
            node.AppendChild(usNode);
        }
        private void btnXML_Click(object sender, EventArgs e)
        {
            sfd.Filter = ".xml|*.xml";
            sfd.ShowDialog();
            XmlDocument xml = new XmlDocument();

            CrearXml(xml, txtNombre.Text, txtEdad.Text, txtTelefono.Text, txtDomicilio.Text, txtLdN.Text);
            txtDomicilio.Clear();
            txtEdad.Clear();
            txtLdN.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();

          xml.Save(sfd.FileName);
        }

    }

}
