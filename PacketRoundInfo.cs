using System;
using System.Text;

namespace NetworkLibrary
{
    public class PacketRoundInfo : Packet
    {
        private PInteger _maxTurn = new PInteger();
        private PFloat _leftTime = new PFloat();

        public PacketRoundInfo(int PacketType) : base(PacketType, 2)
        {
            _field[0] = _maxTurn;
            _field[1] = _leftTime;
        }

        public void InitPacketRoundInfo()
        {
            Random random = new Random();

            _maxTurn.n = random.Next();
            _leftTime.f = random.Next();

            _totalSize.n = (byte)this.GetSize();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());

            sb.Append(string.Format("MaxTurn : {0}, LeftTime : {1}", _maxTurn, _leftTime));

            return sb.ToString();
        }
    }
}