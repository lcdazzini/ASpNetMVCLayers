using ASpNetMVCLayers.Musicas.AcessoaDados.Entity.TypeConfiguration;
using ASpNetMVCLayers.Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpNetMVCLayers.Musicas.AcessoaDados.Entity.Context
{
	public class MusicasDbContext : DbContext
	{
		public DbSet<Album> Albuns { get; set; }

		public MusicasDbContext()
		{
			Configuration.LazyLoadingEnabled = false;
			Configuration.ProxyCreationEnabled = false;
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
		}
	}
}
