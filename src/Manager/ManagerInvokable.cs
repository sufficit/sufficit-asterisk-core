using Sufficit.Asterisk.Manager.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.Manager
{
    /// <summary>
    /// Classe base abstrata que fornece implementação comum para todos os "invokables".
    /// Isso reduz a duplicação de código nas classes derivadas.
    /// </summary>
    public abstract class ManagerInvokable
    {
        // A propriedade Key é implementada aqui uma única vez.
        public string Key { get; }

        // A classe derivada deve especificar o tipo de evento que manipula.
        public abstract Type Type { get; }

        // A classe derivada deve especificar como contar seus assinantes.
        public abstract int Count { get; }

        // O evento para notificar sobre mudanças no número de assinantes (para limpeza automática).
        public event EventHandler? OnChanged;

        /// <summary>
        /// Método protegido para que as classes derivadas possam disparar o evento OnChanged.
        /// </summary>
        protected void RaiseOnChanged() => OnChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// O método principal que será chamado para invocar os handlers de evento.
        /// </summary>
        public abstract void Invoke(object? sender, IManagerEvent e);

        /// <summary>
        /// Construtor que força todas as classes derivadas a terem uma chave (key).
        /// </summary>
        protected ManagerInvokable(string key)
        {
            this.Key = key;
        }
    }
}