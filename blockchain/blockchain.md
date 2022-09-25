
Tools:

metamask for wallet

https://remix.ethereum.org/ for IDE

https://app.tryethernal.com/transactions - explorer for ETH private blockchain (doesn work)

https://contraktor.netlify.app/ - explorer



## Secret and Ephemeral


```
spooky_hash

    0:
    bytes32: 0x2b8a95ae6adb40a4fd5a457e05a47225dff3b530f72e404ea8fb787a9bff6185
```

we want the `_secret_number` and `_not_yours` that constructs the contract.

go copy the `xxx._metadata.json` from build artifacts, then paste into remix console as the abi

```js
jsondata = {...}
address = '0x6E4198C61C75D1B4D1cbcd00707aAC7d76867cF8'
contract = new web3.eth.Contract(jsondata.abi, address)
```

```js
contract.options
0x6E4198C61C75D1B4D1cbcd00707aAC7d76867cF8
{"address":"0x6E4198C61C75D1B4D1cbcd00707aAC7d76867cF8","jsonInterface":[{"inputs":[{"internalType":"string","name":"_not_yours","type":"string"},{"internalType":"uint256","name":"_secret_number","type":"uint256"}],"stateMutability":"nonpayable","type":"constructor"},{"inputs":[{"internalType":"address","name":"","type":"address"}],"name":"cool_wallet_addresses","outputs":[{"internalType":"uint256","name":"","type":"uint256"}],"stateMutability":"view","type":"function","constant":true,"signature":"0x7c46a9b0"},{"inputs":[],"name":"giveTheFunds","outputs":[],"stateMutability":"payable","type":"function","payable":true,"signature":"0x23cfb56f"},{"inputs":[{"internalType":"string","name":"secret","type":"string"},{"internalType":"uint256","name":"secret_number","type":"uint256"},{"internalType":"address","name":"_owner_address","type":"address"}],"name":"retrieveTheFunds","outputs":[],"stateMutability":"nonpayable","type":"function","signature":"0xecd424df"},{"inputs":[],"name":"seconds_in_a_year","outputs":[{"internalType":"int256","name":"","type":"int256"}],"stateMutability":"view","type":"function","constant":true,"signature":"0x1ac749ff"},{"inputs":[],"name":"spooky_hash","outputs":[{"internalType":"bytes32","name":"","type":"bytes32"}],"stateMutability":"view","type":"function","constant":true,"signature":"0xeb087bfb"}]}

contract.property
```

