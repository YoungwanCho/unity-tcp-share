using System;
using System.Text;
using NetworkLibrary;

public class PacketUserInfo : Packet
{
    private PString name = new PString();
    private PInteger age = new PInteger();
    
    private PByte pbyte = new PByte();
    private PSByte psbyte = new PSByte();
    private PShort pshort = new PShort();
    private PInteger pinteger = new PInteger();
    private PUInteger puinteger = new PUInteger();
    private PFloat pfloat = new PFloat();
    private PLong plong = new PLong();
    private PULong pulong = new PULong();

    public PacketUserInfo(int packetType) : base(packetType, 10)
    {
        _field[0] = name;
        _field[1] = age;

        _field[2] = pbyte;
        _field[3] = psbyte;
        _field[4] = pshort;
        _field[5] = pinteger;
        _field[6] = puinteger;
        _field[7] = pfloat;
        _field[8] = plong;
        _field[9] = pulong;
    }

    public void InitPacketUserInfo()
    {
        Random random = new Random();

        name.str = "cho";
        age.n = random.Next();
        pbyte.n = (byte)random.Next();
        psbyte.n = (sbyte)random.Next();
        pshort.n = (short)random.Next();
        pinteger.n = random.Next();
        puinteger.n = (uint)random.Next();
        pfloat.f = random.Next();
        plong.n = random.Next();
        pulong.n = (ulong)random.Next();

        _totalSize.n = (byte)this.GetSize();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString());

        sb.Append(string.Format("Name : {0}, Age : {1}, pbyte : {2}, psbyte : {3}, pshort : {4}, pinteger : {5}, puinteger : {6}, pfloat : {7}, plong : {8} pulong : {9}",
            name.str,
            age.n,
            pbyte.n,
            psbyte.n,
            pshort.n,
            pinteger.n,
            puinteger.n,
            pfloat.f,
            plong.n,
            pulong.n
            ));

        return sb.ToString();
    }
}