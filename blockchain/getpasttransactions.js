const latest = await web3.eth.getBlockNumber();
contract = new web3.eth.Contract(abi, contractAddress);
// logs = await contract.getPastEvents("Transfer", {
//   fromBlock: 0,
//   toBlock: latest,
//   filter:
//     eventType === EventType.send ? { from: address } : { to: address },
// });

logs = contract.getPastEvents("Transfer", {fromBlock: 0, toBlock: latest})