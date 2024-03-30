using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Comportamental.State.Case1
{
    public class Pedido
    {
        private IState _aguardandoPagamento;
        private IState _pago;
        private IState _cancelado;
        private IState _enviado;

        private IState _estadoAtual;

        public Pedido()
        {
            _aguardandoPagamento = new AguardandoPagamentoState(this);
            _pago = new PagoState(this);
            _cancelado = new CanceladoState(this);
            _enviado = new EnviadoState(this);

            _estadoAtual = _aguardandoPagamento;
        }

        public void RealizarPagamento()
        {
            _estadoAtual.SucessoAoPagar();
        }

        public void CancelarPedido()
        {
            _estadoAtual.CancelarPedido();
        }

        public void DespacharPedido()
        {
            try
            {
                _estadoAtual.DespacharPedido();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void EstadoAtual(IState estado)
        {
            _estadoAtual = estado;
        }

        public IState AguardandoPagamento
        {
            get { return _aguardandoPagamento; }
        }

        public IState Pago
        {
            get { return _pago; }
        }

        public IState Cancelado
        {
            get { return _cancelado; }
        }

        public IState Enviado
        {
            get { return _enviado; }
        }
    }
}
