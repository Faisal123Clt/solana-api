<p align="center">
  <img src="https://zrcdn.net/static/img/logos/paidwork/paidwork-logo-github.png" alt="Paidwork" />
</p>

<h3 align="center">
  Multi-purpose Solana Blockchain based library for custom solutions.
</h3>

<p align="center">
  <a href="https://github.com/paidworkco/solana-api">
    <img alt="GitHub Repository Stars Count" src="https://img.shields.io/github/stars/paidworkco/solana-api?style=social" />
  </a>
    <a href="https://x.com/paidworkco">
        <img alt="Follow Us on X" src="https://img.shields.io/twitter/follow/paidworkco?style=social" />
    </a>
</p>
<p align="center">
    <a href="http://commitizen.github.io/cz-cli/">
        <img alt="Commitizen friendly" src="https://img.shields.io/badge/commitizen-friendly-brightgreen.svg" />
    </a>
    <a href="https://github.com/paidworkco/worken-sdk-php">
        <img alt="License" src="https://img.shields.io/github/license/paidworkco/worken-sdk-php" />
    </a>
    <a href="https://github.com/paidworkco/worken-sdk-php/pulls">
        <img alt="PRs Welcome" src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" />
    </a>
</p>

SDK library providing access to send, receive, burn Tokens, manage wallets. Multi-purpose Solana Blockchain based library for custom solutions.
<p align="center">
 <h3 align="center">Endpoints<h3/>
<p/>

* CreateTransaction
* CreateWallet
* CreateWalletWordCount
* CreateWalletWordList
* CreateWalletFull




## CreateTransaction

#### [POST] /api/Transactions/CreateTransaction

#### Body structure
```
public class CreateTransactionRequest
{

    public string fromAccountPublicKey { get; set; }

    public string fromAccountPrivateKey { get; set; }

    public string toAccountPublicKey { get; set; }

    public ulong lanPorts {  get; set; }
}
```
#### Result
String



## CreateWallet

#### [POST] /api/Wallet/CreateWallet

#### Body structure
```
empty
``` 

#### Example result [JSON]
<details>

```json
{
  "account": {
    "privateKey": {
      "key": "45oED964ffnj1Br6tDbwcLNdi8JaZqHciVdWeaJhLVwB4JWZ3SRWE7LtZn4Zh4ntqjrDD7ksyMaPRBuMEnfdhojz",
      "keyBytes": "mjAR0I/E+pNVwqxQ+Z3yGb1o0z5uELRb60DZikAQFDADskNwpOnFtC30jRx+Cyni+o3ALdANvDmJtJVU8cCuNQ=="
    },
    "publicKey": {
      "key": "FRt3vuU8aPPs74ZeH5CA6QD9WYutvVzzsySTYSTD1dn",
      "keyBytes": "A7JDcKTpxbQt9I0cfgsp4vqNwC3QDbw5ibSVVPHArjU="
    }
  },
  "mnemonic": {
    "isValidChecksum": true,
    "wordList": {
      "space": " ",
      "wordCount": 2048
    },
    "indices": [
      1224,
      1684,
      34,
      1881,
      1701,
      1350,
      453,
      1818,
      519,
      2037,
      1451,
      1540
    ],
    "words": [
      "october",
      "spoon",
      "affair",
      "twenty",
      "start",
      "potato",
      "december",
      "today",
      "domain",
      "wrong",
      "rely",
      "scene"
    ]
  }
}
```

</details>


## CreateWalletWordCount

#### [POST] /api/Wallet/CreateWalletWordCount

#### Body structure
```
int

``` 
#### Possible values that represent number of words
12 15 18 21 24

#### Example result [JSON]
<details>

```json
{
  "account": {
    "privateKey": {
      "key": "45oED964ffnj1Br6tDbwcLNdi8JaZqHciVdWeaJhLVwB4JWZ3SRWE7LtZn4Zh4ntqjrDD7ksyMaPRBuMEnfdhojz",
      "keyBytes": "mjAR0I/E+pNVwqxQ+Z3yGb1o0z5uELRb60DZikAQFDADskNwpOnFtC30jRx+Cyni+o3ALdANvDmJtJVU8cCuNQ=="
    },
    "publicKey": {
      "key": "FRt3vuU8aPPs74ZeH5CA6QD9WYutvVzzsySTYSTD1dn",
      "keyBytes": "A7JDcKTpxbQt9I0cfgsp4vqNwC3QDbw5ibSVVPHArjU="
    }
  },
  "mnemonic": {
    "isValidChecksum": true,
    "wordList": {
      "space": " ",
      "wordCount": 2048
    },
    "indices": [
      1224,
      1684,
      34,
      1881,
      1701,
      1350,
      453,
      1818,
      519,
      2037,
      1451,
      1540
    ],
    "words": [
      "october",
      "spoon",
      "affair",
      "twenty",
      "start",
      "potato",
      "december",
      "today",
      "domain",
      "wrong",
      "rely",
      "scene"
    ]
  }
}
```

</details>



## CreateWalletWordList

#### [POST] /api/Wallet/CreateWalletWordList

#### Body structure
```
string
``` 
#### Possible values that represents wordList
"English", "Japanese", "ChineseSimplified", "ChineseTraditional", "Spanish", "French", "PortugueseBrazil", "Czech"

#### Example result [JSON]
<details>

```json
{
  "account": {
    "privateKey": {
      "key": "45oED964ffnj1Br6tDbwcLNdi8JaZqHciVdWeaJhLVwB4JWZ3SRWE7LtZn4Zh4ntqjrDD7ksyMaPRBuMEnfdhojz",
      "keyBytes": "mjAR0I/E+pNVwqxQ+Z3yGb1o0z5uELRb60DZikAQFDADskNwpOnFtC30jRx+Cyni+o3ALdANvDmJtJVU8cCuNQ=="
    },
    "publicKey": {
      "key": "FRt3vuU8aPPs74ZeH5CA6QD9WYutvVzzsySTYSTD1dn",
      "keyBytes": "A7JDcKTpxbQt9I0cfgsp4vqNwC3QDbw5ibSVVPHArjU="
    }
  },
  "mnemonic": {
    "isValidChecksum": true,
    "wordList": {
      "space": " ",
      "wordCount": 2048
    },
    "indices": [
      1224,
      1684,
      34,
      1881,
      1701,
      1350,
      453,
      1818,
      519,
      2037,
      1451,
      1540
    ],
    "words": [
      "october",
      "spoon",
      "affair",
      "twenty",
      "start",
      "potato",
      "december",
      "today",
      "domain",
      "wrong",
      "rely",
      "scene"
    ]
  }
}
```

</details>


## CreateWalletFull

#### [POST] /api/Wallet/CreateWalletFull

#### Body structure
```csharp
public class WalletCreationRequest
{
    public string WordList { get; set; }

    public int WordCount { get; set; }
}
``` 
#### Possible values for WordCount that represent number of words
12 15 18 21 24

#### Possible values for WordList that represents wordList
"English", "Japanese", "ChineseSimplified", "ChineseTraditional", "Spanish", "French", "PortugueseBrazil", "Czech"

#### Example result [JSON]
<details>

```json
{
  "account": {
    "privateKey": {
      "key": "45oED964ffnj1Br6tDbwcLNdi8JaZqHciVdWeaJhLVwB4JWZ3SRWE7LtZn4Zh4ntqjrDD7ksyMaPRBuMEnfdhojz",
      "keyBytes": "mjAR0I/E+pNVwqxQ+Z3yGb1o0z5uELRb60DZikAQFDADskNwpOnFtC30jRx+Cyni+o3ALdANvDmJtJVU8cCuNQ=="
    },
    "publicKey": {
      "key": "FRt3vuU8aPPs74ZeH5CA6QD9WYutvVzzsySTYSTD1dn",
      "keyBytes": "A7JDcKTpxbQt9I0cfgsp4vqNwC3QDbw5ibSVVPHArjU="
    }
  },
  "mnemonic": {
    "isValidChecksum": true,
    "wordList": {
      "space": " ",
      "wordCount": 2048
    },
    "indices": [
      1224,
      1684,
      34,
      1881,
      1701,
      1350,
      453,
      1818,
      519,
      2037,
      1451,
      1540
    ],
    "words": [
      "october",
      "spoon",
      "affair",
      "twenty",
      "start",
      "potato",
      "december",
      "today",
      "domain",
      "wrong",
      "rely",
      "scene"
    ]
  }
}
```

</details>
