#!/Usr/bin/bash
echo "Please enter number: "
#INPUT [uncomment & modify if required]
##declare -i sampleInput= 0
declare -i result= 404
read sampleInput
## Adding variable to assit with clairity.
declare -i fibiotchNum= $(($sampleInput - 2))
declare -i num= $(($sampleInput - 1))

#write your Logic here:
## This site was used to assist logic creation 'geeksforgeeks.org/program-for-the-nth-fibonacci-number'
## need to use for loop. comment made at 5 min left on challange
## $sampleInput= fibiotchNum
## $sampleInput= 1
if(( $sampleInput >= 0 ))
then
    $sampleInput= `$num + $fibiotchNum`
else
    echo "please enter a valid number"
fi

#OUTPUT [uncomment & modify if required]
echo $sampleInput