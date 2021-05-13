﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            // Builder utiliza o padrão Fluent

            builder.Property(p => p.DataPedido)
                .IsRequired();

            builder.Property(p => p.UsuarioId)
                .IsRequired();

            builder.Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder.Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(2);

            builder.Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.NumeroEndereco)
                .IsRequired();

            builder.Property(p => p.FormaPagamentoId)
                .IsRequired();

            builder.Property(p => p.FormaPagamento)
                .IsRequired();

            builder.Property(p => p.ItensPedido)
                .IsRequired();

        }
    }
}