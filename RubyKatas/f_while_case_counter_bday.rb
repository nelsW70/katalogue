
i = 1

while i <= 3

puts "What month were you born?"
month = gets.chomp.downcase

case month

when "december", "january", "february"
    puts "It was so cold in winter!"
    i = i + 1
when "march","april","may"
    puts "You were born in spring!"
    i = i + 1
when "june","july","august"
    puts "You were a summer baby!"
    i = i + 1
when "september","october","november"
    puts "You were born in the fall!"
    i = i + 1
end
end
puts "Bye bye baby"
