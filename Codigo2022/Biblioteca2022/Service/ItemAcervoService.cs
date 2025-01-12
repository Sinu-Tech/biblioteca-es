﻿using Core;
using Core.Service;
using Microsoft.EntityFrameworkCore;

namespace Service
{
	public class ItemAcervoService : IItemAcervoService
	{
		private readonly BibliotecaContext _context;

		public ItemAcervoService(BibliotecaContext context)
		{
			_context = context;	
		}

		/// <summary>
		/// Cria um novo item no acervo
		/// </summary>
		/// <param name="itemAcervo">dados do item acervo</param>
		/// <returns>id gerado</returns>
		public int Create(Itemacervo itemAcervo)
		{
			_context.Add(itemAcervo);
			_context.SaveChanges();
			return itemAcervo.IdItemAcervo;
		}

		/// <summary>
		/// Remover item acervo da base de dados
		/// </summary>
		/// <param name="idItemAcervo">id a ser removido</param>
		public void Delete(int idItemAcervo)
		{
			var _itemAcervo = _context.Itemacervos.Find(idItemAcervo);
			_context.Remove(_itemAcervo);
			_context.SaveChanges();
		}
		/// <summary>
		/// Atualiza os dados de um item no acervo
		/// </summary>
		/// <param name="itemAcervo">novos dados do item acervo</param>
		public void Edit(Itemacervo itemAcervo)
		{
			_context.Update(itemAcervo);
			_context.SaveChanges();
		}

		/// <summary>
		/// Busca os dados de um item do acervo
		/// </summary>
		/// <param name="idItemAcervo">id a ser buscado</param>
		/// <returns>todos os dados do item acervo</returns>
		public Itemacervo Get(int idItemAcervo)
		{
			return _context.Itemacervos.Find(idItemAcervo);
		}

		/// <summary>
		/// Obter todos os itens do acervo cadastrados
		/// </summary>
		/// <returns>todos os itens acervo</returns>
		public IEnumerable<Itemacervo> GetAll()
		{
			return _context.Itemacervos.AsNoTracking();
		}
	}
}
