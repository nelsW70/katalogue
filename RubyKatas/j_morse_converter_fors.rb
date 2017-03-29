
puts "What is your message to be converted into morse code?"
message = gets.chomp

split = message.chars.to_a
puts split.to_s

alpha = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
    'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'w', 'x',
    'y', 'z']

morse = [".-", "-...", "-.-.", "-..", ".", "..-.",
    "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
    "--.-", ".-.", ".-.", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."]

for i in 0..split.length-1
    for j in 0..alpha.length-1
        if split[i] == alpha[j]
            print morse[j] + " "
        end
    end
end
