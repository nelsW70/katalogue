
puts "What is the length of your box?"
length = gets.chomp.to_i

puts "What is the width of your box?"
width = gets.chomp.to_i

area = length * width
puts "Your area is #{area}."

perimeter = (length * 2 ) + (width * 2)
puts "Your perimeter is #{perimeter}."

puts "You can grow " + (area * 16).to_s + " carrots, " + (area * 3).to_s +
" corn stalks, or " + (area * 9).to_s + " beets on your land so eat up!"
