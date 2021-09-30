function solve(str = "", words = []) {
  const lenghtEachWord = words[0].length;
  const totalWordLength = lenghtEachWord * words.length;
  const wordStr = words.join("").split("").sort().join("");

  const arr = [];
  let start = 0;

  while (start < str.length) {
    const fractionOfString = str.substr(start, totalWordLength);
    const a = fractionOfString.split("").sort().join("");
    if (a === wordStr) {
      arr.push(start);
      start = start + lenghtEachWord;
    } else {
      start++;
    }
  }

  return arr;
}
