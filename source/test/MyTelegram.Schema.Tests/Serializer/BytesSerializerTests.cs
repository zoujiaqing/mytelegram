﻿// ReSharper disable StringLiteralTypo
namespace MyTelegram.Schema.Serializer;

public class BytesSerializerTests
{
    [MemberData(nameof(GetSerializeTestDataLengthLessThan254))]
    [MemberData(nameof(GetSerializeTestDataLengthGreaterThan253))]
    [Theory]
    public void Serialize_Data_Test(string inputBytesData, string expectedBytesData)
    {
        // Arrange
        var dataBytes = inputBytesData.ToBytes();
        var expectedBytes = expectedBytesData.ToBytes();
        var stream = new MemoryStream();
        var bw = new BinaryWriter(stream);
        var serializer = CreateSerializer();

        // Act
        serializer.Serialize(dataBytes, bw);

        // Assert
        var serializedBytes = stream.ToArray();
        serializedBytes.ShouldBeEquivalentTo(expectedBytes);
    }

    [MemberData(nameof(GetSerializeTestDataLengthLessThan254))]
    [MemberData(nameof(GetSerializeTestDataLengthGreaterThan253))]
    [Theory]
    public void Deserialize_Data_Test(string expectedBytesData, string inputBytesData)
    {
        // Arrange
        var expectedBytes = expectedBytesData.ToBytes();
        var inputBytes = inputBytesData.ToBytes();
        var br = new BinaryReader(new MemoryStream(inputBytes));
        var serializer = CreateSerializer();

        // Act
        var actualData = serializer.Deserialize(br);

        // Assert
        actualData.ShouldBeEquivalentTo(expectedBytes);
    }

    public static IEnumerable<object[]> GetSerializeTestDataLengthLessThan254()
    {
        // 1
        yield return new object[] { "8A", "018A0000" };

        // 3
        yield return new object[] { "B05EDE", "03B05EDE" };

        // 253
        yield return new object[]
        {
            "2586A2E2FA26A0CAED85146EC93A1EEE417A45165C0909097B39A7D8FEDB6D4BCCEEC3C74F4054732CEA1EB8C355E259C8A54A19C02C5040A6F61A7881D688A7D69CD8F89281588CD3B7097EAEBA11B757A871442614CE093D1B43CE571951C9AF7DA7AA32BF0D2C4755E7092E9563CA379FCB4C5736B67070F67CDD8D18166FF2C134603518DDBD890CE2294C698E8A1B45FAB17882EB0141863E45583DC4CE09D005F2C0897DDBC026CD12CDCF42F02C4F652AE882237DA65B03EB35317E5E6D58B3E1E00C5CF10C7EE6E5B4768900F761B831C8B6B21E10EE96B0DC05C4B94A21B1D2F877D71C7DEDD6A467A92FA856B58FFF05A45573CF2E67DF78",
            "FD2586A2E2FA26A0CAED85146EC93A1EEE417A45165C0909097B39A7D8FEDB6D4BCCEEC3C74F4054732CEA1EB8C355E259C8A54A19C02C5040A6F61A7881D688A7D69CD8F89281588CD3B7097EAEBA11B757A871442614CE093D1B43CE571951C9AF7DA7AA32BF0D2C4755E7092E9563CA379FCB4C5736B67070F67CDD8D18166FF2C134603518DDBD890CE2294C698E8A1B45FAB17882EB0141863E45583DC4CE09D005F2C0897DDBC026CD12CDCF42F02C4F652AE882237DA65B03EB35317E5E6D58B3E1E00C5CF10C7EE6E5B4768900F761B831C8B6B21E10EE96B0DC05C4B94A21B1D2F877D71C7DEDD6A467A92FA856B58FFF05A45573CF2E67DF780000"
        };
    }

    public static IEnumerable<object[]> GetSerializeTestDataLengthGreaterThan253()
    {
        // 254
        yield return new object[]
        {
            "E3015AEB327305D451B5BFFEAA5E1AEB15DE811373FC0B159D333DB5439715FD19570BCB43C6F3E31D2FF6B501817F67479BCADE30F395B86FDF73ACC354A1D90C2F592FD88CB83337F7D2D249775A2FE4B3EF169AAD2ABD7405940CEFCE9BC025E02FE81F4437C2606E2AD2CF807E334F954671302CD53C47EB8462E44AD73F9FDB3095827542DD6060F3EF2E1472A3B11F0857CBE65B3839C3AD95DE71F0625A6CBDE94B8F3CD1F28993DE72BB9F089C6E30968CB3E365F0AE2D35490AD958C04DE9FF433C5C710D44DF7710C5A5B9A96A113659933B7212BC6BB2715FD7B080E2E01E7583AF6A99967A0E559E74363ACAEE7A94D1A601CF0DAD4B6DC5",
            "FEFE0000E3015AEB327305D451B5BFFEAA5E1AEB15DE811373FC0B159D333DB5439715FD19570BCB43C6F3E31D2FF6B501817F67479BCADE30F395B86FDF73ACC354A1D90C2F592FD88CB83337F7D2D249775A2FE4B3EF169AAD2ABD7405940CEFCE9BC025E02FE81F4437C2606E2AD2CF807E334F954671302CD53C47EB8462E44AD73F9FDB3095827542DD6060F3EF2E1472A3B11F0857CBE65B3839C3AD95DE71F0625A6CBDE94B8F3CD1F28993DE72BB9F089C6E30968CB3E365F0AE2D35490AD958C04DE9FF433C5C710D44DF7710C5A5B9A96A113659933B7212BC6BB2715FD7B080E2E01E7583AF6A99967A0E559E74363ACAEE7A94D1A601CF0DAD4B6DC50000"
        };

        // 512
        yield return new object[]
        {
            "1CBB65F9B0CA8EB14FB956E0A7C3285B7A4FCCEACD3E6A12FB231ACC6F53C8ACDE096C2D6619F4DC44DF78EA1C22D0C97B42B3913BAFB20611CB092D8DDE854A91F47CB0C21F61813430469E7C3DCBDC2520494D690A0356965E49351917C4127B3BF76B0531510BD684158565B9CFCD08C51DC9F8A4650EE8B7637ED67CC2E1641713B6D111539902991E81F83B35950302EAC773F1FAC6DE8FA9448A4B40554DD4FDDDB969AC9706AB51CE84C562826C2695A977C20C09874C5264548234F658A83CD59C2870E9AF31423C782368E91852E0AA3F7A73C512017DEAB1D4443E46B61CE5FB9D2ADD800771C7D879C0E457319ACA3D12A1A8737094B079D901C8DCB7BC69428D3502532867CE086788667888D91ADEBCC59342D32ACD76E42D9663260D2069C13DEF4FF35F592287A7B7ECF7A630FC2DF995F736D658C779A4DF255F1BD8629BF427B329A3BBD0AFC2359B5ABD9CACA622723B1990B469DDFAF09D809D28260E5F75035B3EEAB9D1010E4F82E6FF77617C2A48B8E61F47BF264B36E4E4ED7C87F97661395B64DEF2A68C6A980F3EDB930D5B1487E131198B7481D2245C94D938A85A7233EFCA6F30958F147C0C400CA4BB4E6785CAF6581C9C067D2784A7A33EC34C1A52AF1031EB23AA57EBACCC57731466C04759968CA8412FEB11344B1BD377D41A7DEABE8D19DBA4ADF556D99A6095AB49F968CC890066C3",
            "FE0002001CBB65F9B0CA8EB14FB956E0A7C3285B7A4FCCEACD3E6A12FB231ACC6F53C8ACDE096C2D6619F4DC44DF78EA1C22D0C97B42B3913BAFB20611CB092D8DDE854A91F47CB0C21F61813430469E7C3DCBDC2520494D690A0356965E49351917C4127B3BF76B0531510BD684158565B9CFCD08C51DC9F8A4650EE8B7637ED67CC2E1641713B6D111539902991E81F83B35950302EAC773F1FAC6DE8FA9448A4B40554DD4FDDDB969AC9706AB51CE84C562826C2695A977C20C09874C5264548234F658A83CD59C2870E9AF31423C782368E91852E0AA3F7A73C512017DEAB1D4443E46B61CE5FB9D2ADD800771C7D879C0E457319ACA3D12A1A8737094B079D901C8DCB7BC69428D3502532867CE086788667888D91ADEBCC59342D32ACD76E42D9663260D2069C13DEF4FF35F592287A7B7ECF7A630FC2DF995F736D658C779A4DF255F1BD8629BF427B329A3BBD0AFC2359B5ABD9CACA622723B1990B469DDFAF09D809D28260E5F75035B3EEAB9D1010E4F82E6FF77617C2A48B8E61F47BF264B36E4E4ED7C87F97661395B64DEF2A68C6A980F3EDB930D5B1487E131198B7481D2245C94D938A85A7233EFCA6F30958F147C0C400CA4BB4E6785CAF6581C9C067D2784A7A33EC34C1A52AF1031EB23AA57EBACCC57731466C04759968CA8412FEB11344B1BD377D41A7DEABE8D19DBA4ADF556D99A6095AB49F968CC890066C3"
        };
    }

    private BytesSerializer CreateSerializer() => new();
}