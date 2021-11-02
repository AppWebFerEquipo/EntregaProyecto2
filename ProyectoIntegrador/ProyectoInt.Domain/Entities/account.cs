using System;

namespace ProyectoInt.Domain.Entities
{
    public class account
    {
        public record account(string NombreCompleto, string Usuario, string Correo, string Password);
    }
}