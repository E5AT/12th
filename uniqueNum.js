let used=-1, num=-1
for(let i=0;i<20;i++){
do{
    num = Math.floor(Math.random()*7)
}while(used==num)
used=num
console.log(num)
}