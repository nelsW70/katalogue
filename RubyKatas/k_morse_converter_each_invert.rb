morse_alpha = {
"a" => ".-",
"b" => "-...",
"c" => "-.-.",
"d" => "-..",
"e" => ".",
"f" => "..-,.",
"g" => "--.",
"h" => "....",
"i" => "..",
"j" => ".---",
"k" => "-.-",
"l" => ".-..",
"m" => "--",
"n" => "-.",
"o" => "---",
"p" => ".--.",
"q" => "--.-",
"r" =>".-.",
"s" => "...",
"t" =>"-",
"u" =>"..-",
"v" =>"...-",
"w" =>".--",
"x" => "-..-",
"y" => "-.--",
"z" => "--.."
}

puts "Would to translate to morse code (T) or from morse code (F)"
choice = gets.chomp.downcase
case choice
when "t"
  puts "Enter your message to be translated with a space between each character"
  user_input = gets.chomp.downcase
  user_input.each_char do |i|
  print morse_alpha[i]
end
when "f"
  puts "Enter your message to be translated with a space between each character"
  user_input = gets.chomp
  user_input.split.each do |i|
    print morse_alpha.invert[i]
end
puts
end
