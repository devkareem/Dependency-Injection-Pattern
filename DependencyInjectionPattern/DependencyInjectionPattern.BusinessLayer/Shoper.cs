using DependencyInjectionPattern.Infrastructure;

namespace DependencyInjectionPattern.BusinessLayer
{
    public class Shoper : IShoper
    {
        private readonly ICreditCard _card;
        public Shoper(ICreditCard card)
        {
            _card = card;
        }
        public void Charge()
        {
            _card.Charge();
        }
    }
}
