using DesignPatterns.entities.Order;
using DesignPatterns.entities.Order.OrderType;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.entities.Client {
    public class ClientComptant : Client {
        protected override Commande CreeCommande(float prix) {
            return new CommandeComptant(prix);
        }
    }
}
