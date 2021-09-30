function solve(str1 = "", str2 = "") {
  const obj = {};
  for (let i = 0; i < str1.length; i++) {
    obj[str1[i]] = obj[str1[i]] ?? 0;
    obj[str1[i]]++;
  }

  for (let j = 0; j < str2.length; j++) {
    if (obj[str2[j]]) return "YES";
  }
  return "NO";
}
