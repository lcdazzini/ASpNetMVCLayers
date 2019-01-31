﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpNetMVCLayers.Comum.Entity
{
	public abstract class ASpNetMVCLayersEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade> where TEntidade : class
	{
		public ASpNetMVCLayersEntityAbstractConfig()
		{
			ConfigurarNomeTabela();
			ConfigurarCamposTabela();
			ConfigurarChavePrimaria();
			ConfigurarChavesEstrangeiras();
		}

		protected abstract void ConfigurarChavesEstrangeiras();

		protected abstract void ConfigurarChavePrimaria();

		protected abstract void ConfigurarCamposTabela();

		protected abstract void ConfigurarNomeTabela();
	}
}