puts "What is the length of your box?"
length = gets.chomp.to_i

puts "What is the width of your box?"
width = gets.chomp.to_i

area = length * width
puts "Your area is #{area}."

perimeter = (length * 2 ) + (width * 2)
puts "Your perimeter is #{perimeter}."

puts "Would you like to grow carrots, corn or beets?"
crop = gets.chomp.downcase

if crop == "carrots"
    puts "You can grow " + (area * 16).to_s + " carrots on your land!"
elsif crop == "corn"
    puts "You can grow " + (area * 3).to_s + " corn stalks on your land!"
elsif crop == "beets"
    puts "You can grow " + (area * 9).to_s + " beets on your land!"
end


#and


puts "What month were you born in?"
month = gets.chomp.downcase

if month == "december" || month == "january" || month == "february"
    puts "It was so cold in winter!"
elsif month == "march" || month == "april" || month == "may"
    puts "You were born in spring!"
elsif month == "june" || month == "july" || month == "august"
    puts "You were a summer baby!"
elsif month == "september" || month == "october" || month == "november"
    puts "You were born in the fall!"
end
