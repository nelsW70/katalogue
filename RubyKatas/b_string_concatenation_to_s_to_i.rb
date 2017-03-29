puts "\nWhat's your favorite animal?"
response = gets.chomp
puts "\nLook out, it's a giant " + response + "-bird!"



#and



puts "\nWhat's your name partner?"
name = gets.chomp
puts "\nHi " + name + ", how old are you?"
age = gets.chomp.to_i
puts "\nIn five years you will be " + (age + 5).to_s + ". Sleep well."
