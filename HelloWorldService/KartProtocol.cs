using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

[ProtoContract]
public class testContact
{
    [ProtoMember(1)]
    public string ContactCode { get; set; }
    [ProtoMember(2)]
    public string Address1 { get; set; }
    [ProtoMember(3)]
    public string Address2 { get; set; }
    [ProtoMember(4)]
    public string Address3 { get; set; }
    [ProtoMember(5)]
    public string Phone { get; set; }
    [ProtoMember(6)]
    public string Email { get; set; }
}
