﻿namespace App.Api.Modelos
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

<<<<<<< HEAD
=======
        /// <summary>
        /// Establecer relación completa (no requiere FluentApi)
        /// https://henriquesd.medium.com/entity-framework-core-relationships-with-fluent-api-8f741c57b881
        /// </summary>
>>>>>>> main
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
