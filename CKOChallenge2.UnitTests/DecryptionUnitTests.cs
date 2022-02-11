using System;
using CKOChallenge2.Domain.Services;
using CKOChallenge2.Services;
using Shouldly;
using Xunit;

namespace CKOChallenge2.UnitTests;

public class DecryptionUnitTests
{
    private IDecryptionService _decryptionService;

    public DecryptionUnitTests()
    {
        _decryptionService = new DecryptionService();
    }

    [Fact]
    public void GivenEncryptedCardNumber_ShouldDecryptValue()
    {
        var encryptedCardNumber = "cd";
        var expected = "4242424242424242";
        var actual = _decryptionService.DecryptCardNumber(encryptedCardNumber);
        actual.ShouldBe(expected);
    }

    [Fact]
    public void GivenEncryptedCardNumberIsNotEncryptedWithCorrectKey_ShouldNotDecryptValue()
    {
        var encryptedCardNumber = "S9UykOxNQdajhzk5gptUa90+tfidTKWdlYG1tQmEq8U=";
        var actual = _decryptionService.DecryptCardNumber(encryptedCardNumber);
        actual.ShouldBe("Error");
    }

    [Fact]
    public void GivenEncryptedCardNumberIsNotCorrect_ShouldNotDecryptValue()
    {
        var encryptedCardNumber = "CSG8kANdBrlCt4era5Mjmd/I7JdV0Toiv7wizDjxgZA=";
        var expected = "4242424242424242";
        var actual = _decryptionService.DecryptCardNumber(encryptedCardNumber);
        actual.ShouldNotBe(expected);
    }
}