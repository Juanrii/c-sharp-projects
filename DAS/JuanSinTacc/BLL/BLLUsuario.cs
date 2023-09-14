using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BE;
using MPP;

namespace BLL
{
    public class BLLUsuario
    {
        private MPPUsuario _mppUsuario;

        public BLLUsuario()
        {
            _mppUsuario = new MPPUsuario();
        }

        public int Buscar(BEUsuario usuario)
        {
            usuario.Contra = Encriptar(usuario.Contra);
            return _mppUsuario.Buscar(usuario);
        }

        public bool Agregar(BEUsuario nuevoUsuario)
        {
            nuevoUsuario.Contra = Encriptar(nuevoUsuario.Contra);
            return _mppUsuario.Agregar(nuevoUsuario);
        }

        public string Encriptar(string campo)
        {
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] bytess = ue.GetBytes(campo);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hash = md5.ComputeHash(bytess);
            return Convert.ToBase64String(hash);
        }
    }
}
