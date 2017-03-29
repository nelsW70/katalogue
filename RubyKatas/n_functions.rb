def multiply(x, y)
	x * y
end

puts multiply(2, 3)




#and



def add_a_bird(name)
  name + "-bird"
end

puts add_a_bird("Bosephus")



#and



def add_a_bird(name)
  name + "-bird!"
end

puts "Name something and we'll add a bird to it!"
puts add_a_bird(gets.chomp)




#and



def times_ten(x)
  x * 10
end

puts "Enter a number and we'll x10 it!"
answer = gets.chomp.to_i
puts times_ten(answer).to_s + "...#math!"
