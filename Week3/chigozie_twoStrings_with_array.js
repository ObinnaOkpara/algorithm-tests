function twoStrings(str1 = "", str2 = "") {
  const arr = new Array(26).fill(false);
  for (let i = 0; i < str1.length; i++) {
    arr[str1[i].charCodeAt() - "a".charCodeAt()] = true;
  }
  for (let j = 0; j < str2.length; j++) {
    if (arr[str2[j].charCodeAt() - "a".charCodeAt()]) {
      return "YES";
    }
  }
  return "NO";
}
