# [Duplicate Encoder](https://www.codewars.com/kata/54b42f9314d9229fd6000d9c)

---

The goal of this exercise is to convert a string to a new string where each character in the new string is '(' if that character appears only once in the original string, or ')' if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

Examples:
```
"din" => "((("

"recede" => "()()()"

"Success" => ")())())"

"(( @" => "))(("
```

---

### 中文大意

字串中所有的字都使用 ( 和 ) 來取代，如果有重複的字使用 ) ，沒有的話使用 ( ，大小寫不區分
