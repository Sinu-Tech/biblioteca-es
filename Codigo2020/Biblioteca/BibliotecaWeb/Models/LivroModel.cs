﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public partial class LivroModel
    {
		[Required]
		[Key]
		[StringLength(20)]
        public string Isbn { get; set; }
		[Display(Name ="Editora")]
        public int IdEditora { get; set; }
		[StringLength(50)]
		public string Nome { get; set; }
		[DataType(DataType.Date)]
		[Display(Name ="Data Publicação")]
        public DateTime? DataPublicacao { get; set; }
		[StringLength(300)]
		public string Resumo { get; set; }

		public string NomeEditora { get; set; }
    }
}
