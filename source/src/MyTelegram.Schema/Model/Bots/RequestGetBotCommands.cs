﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Bots;

///<summary>
///See <a href="https://core.telegram.org/method/bots.getBotCommands" />
///</summary>
[TlObject(0xe34c0dd6)]
public sealed class RequestGetBotCommands : IRequest<TVector<MyTelegram.Schema.IBotCommand>>
{
    public uint ConstructorId => 0xe34c0dd6;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/BotCommandScope" />
    ///</summary>
    public MyTelegram.Schema.IBotCommandScope Scope { get; set; }
    public string LangCode { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Scope.Serialize(bw);
        bw.Serialize(LangCode);
    }

    public void Deserialize(BinaryReader br)
    {
        Scope = br.Deserialize<MyTelegram.Schema.IBotCommandScope>();
        LangCode = br.Deserialize<string>();
    }
}
