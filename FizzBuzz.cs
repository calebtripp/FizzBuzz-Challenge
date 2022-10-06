public string FizzBuzzChallenge (int fBChk)
{
if (fBChk % 3 == 0) return "fizz";
if (fBChk % 5 == 0) return "buzz";
if (fBChk % 3 == 0 && fBChk % 5 == 0) return "fizzbuzz";
}