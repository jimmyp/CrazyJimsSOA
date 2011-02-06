<table>
  <tr>
    <th class="placeOrderColumn"></th>
  </tr>
	{#foreach $T as placeOrder}
	<tr>
		<td class="placeOrderColumn">
			{#if $T.placeOrder.canPlace == true} 
				<input type="submit" value="Place Order" />
			{#else} 
				<p>Unavailable</p>
			{#/if}			
		</td>
	</tr>
	{#/for}
</table>