for i in 1..100
    if i % 15 == 0
        puts "Fizzbuzz"
    elsif i % 3 == 0
        puts "Fizz"
    elsif i % 5 == 0
        puts "Buzz"
    else puts i
    end
end


#and


for i in 100.downto(1)
    if i % 15 == 0
        puts "Fizzbuzz"
    elsif i % 3 == 0
        puts "Fizz"
    elsif i % 5 == 0
        puts "Buzz"
    else puts i
    end
end


#and


i = 0
while i < 15
    if i % 15 == 0
        puts "Fizzbuzz"
    elsif i % 3 == 0
        puts "Fizz"
    elsif i % 5 == 0
        puts "Buzz"
    else puts i
    end
    i = i + 1
end
