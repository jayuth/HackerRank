function squares(a, b){
    if(a > b) return 0;
    // since we know the range/pattern, we can just subtract the max num - min num
    // e.g. sqrt 24 and sqrt 49 = 5 and 7 = 7 -5 = 2 
    let count = Math.floor(Math.sqrt(b)) - Math.ceil(Math.sqrt(a)) + 1;
    return count;
}