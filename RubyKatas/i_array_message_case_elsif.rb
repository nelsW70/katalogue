
inbox = []
run_prog = true
while run_prog == true

  puts "Would you like to (S)ave a message, (R)etreive a message or (E)xit the program?"
  menu_choice = gets.chomp.downcase

  case menu_choice

  when "s"
    puts "Please enter your message"
    message = gets.chomp
      inbox << message
      puts "Your message ID is #{inbox.length-1}"
  when "r"
    puts "What is the ID of the message you would like to retrieve?"
    id_choice = gets.to_i
    puts "Your message is:" + inbox[id_choice].to_s
  when "e"
    puts "Until next time brave one."
    run_prog = false
  end
end





#and






inbox = []  #sets up the array for the message

message_box = true  #makes a boolean variable for the main loop
while message_box == true  #while this is true, loop will keep on going
  puts "Would you like to (s)ave a message, (r)etrieve a message, or e(x)it?"
  what_to_do = gets.downcase.chomp  #takes their input and makes sure its in lowercase
  if what_to_do != "s" && what_to_do !=  "r" && what_to_do != "x"  #if they didn't give an s, r, or x, tell them to try again
    puts "#{what_to_do} was not a valid choice.  Please try again."
  elsif what_to_do == "s"
    puts "What is your message?"
    inbox << gets.chomp  #puts their message at the end of the array
    puts "Your message ID for this message is #{inbox.length - 1}."  #shows their message ID, which is the positoin in the array
  elsif what_to_do == "r"
    puts "What is the message ID of the message that you would like to retrieve?"
    puts inbox[gets.to_i]  #picks their message out of the array
  elsif what_to_do == "x"
    puts "Thank you for using the messaging system. Good bye."
    message_box = false  #changes the boolean to false and ends the loop
  end
end
