#!/usr/bin/bash 

## Author @havelpot {RandyR}
## Tips and tricks were utilized via
## https://www.tutorialspoint.com/unix/shell_scripting.htm

: 'This is a simple game that mods all numbers against 3 and 5'

echo "Good Day to you my fine sir and or madamm"
##echo      ## May add a pause removed line
echo "would you like to play a game y or n?" 
read -p 'response: ' ## boolean expression needed
## declaring variables Yes and No
yes="y"
no="n"
    
    if [ "$response" == "$yes" ] ## current If statement recognizes a response only
     
        echo "Great! Choose a number and if it is divisable by 3 or 5 you will get a response." 
        echo "If you get FIZZBUZZ then you WIN!...not really :( " 
        then
        read nums1  
            if(( $nums1%3 == 0 )) && (( $nums1%5 == 0 ))
            then
                echo "FIZZBUZZ"
            elif(( $nums1% 3 == 0 ))
            then
                echo "FIZZZZZZZ"

            elif(( $nums1%5 == 0 ))
            then
                echo "BUZZZZZZZ"
            else
                echo "Not divisable by 3 or 5"
        fi
    else
        echo "I guess you really did't want to play"
    fi