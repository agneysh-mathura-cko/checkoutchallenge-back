namespace CKOChallenge2.Domain.Services;

public interface IDecryptionService
{
    string DecryptCardNumber(string? encryptedCardNumber);
}