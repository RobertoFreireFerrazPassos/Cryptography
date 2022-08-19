# Cryptography

## Encryption

Encryption is masking or hiding the data by changing the format so that it’s unreadable or indecipherable unless you have the means to decrypt it, so the data remains in place but gets scrambled or hidden.

### Symmetric encryption

- Encrypter, and decrypter — need access to the same key.
- The tricky part is how to store the key and make it available only to the software that needs it.

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/SymmetricEncryption.PNG?raw=true">
</p>

### Asymmetric encryption

- Uses public and private keys to encrypt and decrypt data.
- Either of the keys can be used to encrypt a message; the opposite key from the one used to encrypt the message is used for decryption.

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/AsymmetricEncryption.PNG?raw=true">
</p>

## Hash 

- Hashing is used only to verify data
- The same input will always produce the same output
- It’s impossible to reverse it back to the original data
- Given knowledge of only the hash, it’s infeasible to create another string of data that will create the same hash 

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/Hashing.PNG?raw=true">
</p>

## Token

Tokenization is a process where one tries not to possess the data. It’s a proxy to sensitive information with equivalent non-sensitive information which is the token. In the case of merchants using credit card numbers, instead of encrypting the information one stores it and assigns a key. Just think of it as a vault.

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/Token.PNG?raw=true">
</p>

## References:

https://peter-chang.medium.com/review-3-main-types-of-encryption-hash-symmetric-asymmetric-tutorial-example-understand-5e57c290324c

https://www.c-sharpcorner.com/article/encryption-and-decryption-using-a-symmetric-key-in-c-sharp/

https://www.c-sharpcorner.com/article/implement-symmetric-and-asymmetric-cryptography-algorithms-with-c-sharp/